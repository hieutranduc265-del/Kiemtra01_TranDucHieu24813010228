namespace TechMartManager
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            this.tableLayoutPanel1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // tableLayoutPanel1 (Chia 35% - 65%)
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.panelLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvProducts, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 520);
            this.tableLayoutPanel1.TabIndex = 0;

            // panelLeft
            this.panelLeft.AutoScroll = true;
            this.panelLeft.Controls.Add(this.txtSearch);
            this.panelLeft.Controls.Add(this.lblSearch);
            this.panelLeft.Controls.Add(this.btnExportCsv);
            this.panelLeft.Controls.Add(this.btnDelete);
            this.panelLeft.Controls.Add(this.btnUpdate);
            this.panelLeft.Controls.Add(this.btnAdd);
            this.panelLeft.Controls.Add(this.btnChooseImage);
            this.panelLeft.Controls.Add(this.picAvatar);
            this.panelLeft.Controls.Add(this.cboCategory);
            this.panelLeft.Controls.Add(this.txtQuantity);
            this.panelLeft.Controls.Add(this.txtUnitPrice);
            this.panelLeft.Controls.Add(this.txtProductName);
            this.panelLeft.Controls.Add(this.txtProductId);
            this.panelLeft.Controls.Add(this.lblQty);
            this.panelLeft.Controls.Add(this.lblPrice);
            this.panelLeft.Controls.Add(this.lblCategory);
            this.panelLeft.Controls.Add(this.lblName);
            this.panelLeft.Controls.Add(this.lblId);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(3, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(326, 514);
            this.panelLeft.TabIndex = 0;

            // Controls bên trái
            this.lblId.Text = "Mã SP:";
            this.lblId.Location = new System.Drawing.Point(10, 15);
            this.txtProductId.Location = new System.Drawing.Point(100, 12);
            this.txtProductId.Size = new System.Drawing.Size(200, 22);

            this.lblName.Text = "Tên SP:";
            this.lblName.Location = new System.Drawing.Point(10, 45);
            this.txtProductName.Location = new System.Drawing.Point(100, 42);
            this.txtProductName.Size = new System.Drawing.Size(200, 22);

            this.lblCategory.Text = "Danh mục:";
            this.lblCategory.Location = new System.Drawing.Point(10, 75);
            this.cboCategory.Location = new System.Drawing.Point(100, 72);
            this.cboCategory.Size = new System.Drawing.Size(200, 22);
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblPrice.Text = "Đơn giá:";
            this.lblPrice.Location = new System.Drawing.Point(10, 105);
            this.txtUnitPrice.Location = new System.Drawing.Point(100, 102);
            this.txtUnitPrice.Size = new System.Drawing.Size(200, 22);

            this.lblQty.Text = "Số lượng:";
            this.lblQty.Location = new System.Drawing.Point(10, 135);
            this.txtQuantity.Location = new System.Drawing.Point(100, 132);
            this.txtQuantity.Size = new System.Drawing.Size(200, 22);

            // PictureBox
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(100, 165);
            this.picAvatar.Size = new System.Drawing.Size(120, 100);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnChooseImage.Text = "Chọn Ảnh";
            this.btnChooseImage.Location = new System.Drawing.Point(225, 165);
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);

            // Buttons
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Location = new System.Drawing.Point(10, 280);
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Location = new System.Drawing.Point(110, 280);
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Xóa";
            this.btnDelete.Location = new System.Drawing.Point(210, 280);
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnExportCsv.Text = "Xuất CSV";
            this.btnExportCsv.Location = new System.Drawing.Point(10, 320);
            this.btnExportCsv.Size = new System.Drawing.Size(280, 30);
            this.btnExportCsv.Click += new System.EventHandler(this.ExportCsv_Click);

            // Search Live
            this.lblSearch.Text = "Tìm kiếm:";
            this.lblSearch.Location = new System.Drawing.Point(10, 370);
            this.txtSearch.Location = new System.Drawing.Point(100, 367);
            this.txtSearch.Size = new System.Drawing.Size(190, 22);

            // dgvProducts (DataGridView)
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId, this.colName, this.colCategory, this.colPrice, this.colQty
            });
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.colId.DataPropertyName = "ProductId";
            this.colId.HeaderText = "Mã SP";

            this.colName.DataPropertyName = "ProductName";
            this.colName.HeaderText = "Tên SP";

            this.colCategory.DataPropertyName = "CategoryName";
            this.colCategory.HeaderText = "Danh Mục";

            this.colPrice.DataPropertyName = "UnitPrice";
            this.colPrice.DefaultCellStyle.Format = "N0";
            this.colPrice.HeaderText = "Đơn Giá (VNĐ)";

            this.colQty.DataPropertyName = "Quantity";
            this.colQty.HeaderText = "Số Lượng";

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem });
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.exportCSVToolStripMenuItem, this.exitToolStripMenuItem
            });

            this.exportCSVToolStripMenuItem.Text = "Export CSV (Ctrl+E)";
            this.exportCSVToolStripMenuItem.Click += new System.EventHandler(this.ExportCsv_Click);

            this.exitToolStripMenuItem.Text = "Exit (Ctrl+X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatus });
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;

            // Form1
            this.ClientSize = new System.Drawing.Size(950, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "TechMart Product Manager";

            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}