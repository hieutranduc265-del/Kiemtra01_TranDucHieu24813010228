using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TechMartManager
{
    public partial class MainForm : Form
    {
        private BindingList<Product> productList = new BindingList<Product>();
        private BindingSource bindingSource = new BindingSource();
        private string selectedImagePath = "";

        public MainForm()
        {
            InitializeComponent();
            SetupDataBinding();
            SetupCategories();
            SetupEvents();
            UpdateStatus();
        }

        private void SetupCategories()
        {
            var categories = new[]
            {
                new Category("DT", "Điện thoại"),
                new Category("LT", "Laptop"),
                new Category("PK", "Phụ kiện")
            };

            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryId";
        }

        private void SetupDataBinding()
        {
            bindingSource.DataSource = productList;
            dgvProducts.DataSource = bindingSource;
        }

        private void SetupEvents()
        {
            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;
            txtSearch.TextChanged += TxtSearch_TextChanged;

            exportCSVToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
        }

        private void UpdateStatus()
        {
            lblStatus.Text = $"Tổng số sản phẩm: {productList.Count}";
        }

        private bool ValidateInput()
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                errorProvider1.SetError(txtProductName, "Tên sản phẩm không được để trống!");
                isValid = false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price <= 0)
            {
                errorProvider1.SetError(txtUnitPrice, "Đơn giá phải lớn hơn 0!");
                isValid = false;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                errorProvider1.SetError(txtQuantity, "Số lượng phải >= 0!");
                isValid = false;
            }

            return isValid;
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";
                ofd.Title = "Chọn ảnh sản phẩm";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    picAvatar.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string id = string.IsNullOrWhiteSpace(txtProductId.Text) ? "SP" + (productList.Count + 1).ToString("D3") : txtProductId.Text;

            Product p = new Product(
                id,
                txtProductName.Text.Trim(),
                cboCategory.Text,
                decimal.Parse(txtUnitPrice.Text),
                int.Parse(txtQuantity.Text),
                selectedImagePath
            );

            productList.Add(p);
            ClearInputs();
            UpdateStatus();
            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            if (!ValidateInput()) return;

            Product current = (Product)dgvProducts.CurrentRow.DataBoundItem;
            current.ProductName = txtProductName.Text.Trim();
            current.CategoryName = cboCategory.Text;
            current.UnitPrice = decimal.Parse(txtUnitPrice.Text);
            current.Quantity = int.Parse(txtQuantity.Text);
            current.ImagePath = selectedImagePath;

            bindingSource.ResetBindings(false);
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sản phẩm này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                Product p = (Product)dgvProducts.CurrentRow.DataBoundItem;
                productList.Remove(p);
                ClearInputs();
                UpdateStatus();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower().Trim();
            var filtered = productList.Where(p => p.ProductName.ToLower().Contains(keyword)).ToList();
            bindingSource.DataSource = new BindingList<Product>(filtered);
        }

        private void DgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null && dgvProducts.CurrentRow.DataBoundItem is Product p)
            {
                txtProductId.Text = p.ProductId;
                txtProductName.Text = p.ProductName;
                cboCategory.Text = p.CategoryName;
                txtUnitPrice.Text = p.UnitPrice.ToString();
                txtQuantity.Text = p.Quantity.ToString();
                selectedImagePath = p.ImagePath;

                if (!string.IsNullOrEmpty(p.ImagePath) && File.Exists(p.ImagePath))
                {
                    picAvatar.Image = Image.FromFile(p.ImagePath);
                }
                else
                {
                    picAvatar.Image = null;
                }
            }
        }

        private void ExportCsv_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.FileName = "DanhSachSanPham.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("MaSP,TenSP,DanhMuc,DonGia,SoLuong");

                    foreach (var p in productList)
                    {
                        sb.AppendLine($"\"{p.ProductId}\",\"{p.ProductName}\",\"{p.CategoryName}\",{p.UnitPrice},{p.Quantity}");
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearInputs()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            picAvatar.Image = null;
            selectedImagePath = "";
            errorProvider1.Clear();
        }
    }
}