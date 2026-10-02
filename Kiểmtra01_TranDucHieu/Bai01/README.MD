# BÀI 01: LÝ THUYẾT VÀ CÂU HỎI NGẮN

## Câu 1:Trình bày sự khác nhau giữa Value Types (Kiểu giá trị) và Reference Types(Kiểu tham chiếu) trong C# về cơ chế lưu trữ vùng nhớ (Stack vs Heap).

## 1:Đặc tính
+ Value Types (Kiểu giá trị):Lưu giá trị trực tiếp trên : Stack
+ Reference Types (Kiểu tham chiếu): Giá trị thực tế lưu trên: Heap

## 2:Các kiểu dữ liệu
+ Value Types (Kiểu giá trị): int, float, double, bool, char, struct, enum.
+ Reference Types (Kiểu tham chiếu):class, string, object, interface, array, delegate.

## 3:Gán giá trị (=)
+ Value Types (Kiểu giá trị): Sao chép toàn bộ giá trị. Thay đổi ở biến này không ảnh hưởng đến biến kia.
+ Reference Types (Kiểu tham chiếu):Sao chép địa chỉ tham chiếu. Cả hai biến cùng trỏ vào 1 vùng nhớ trên Heap.

## 4:Giải phóng bộ nhớ
+ Value Types (Kiểu giá trị): Tự động hủy ngay khi ra khỏi scope
+ Reference Types (Kiểu tham chiếu):Do bộ thu gom rác (Garbage Collector - GC) tự động dọn dẹp khi không còn biến nào trỏ tới


## Cơ chế hoạt động :
## Stack
- Đặc điểm: Dung lượng nhỏ, tốc độ truy xuất cực nhanh.
- Cơ chế: Khi một phương thức được gọi, C# tạo ra một Frame trên Stack. Biến kiểu Value Type khai báo cục bộ trong phương thức đó sẽ được lưu trực tiếp tại đây. Khi phương thức kết thúc, Frame bị xóa và bộ nhớ Stack tự giải phóng lập tức.
## Heap
- Đặc điểm: Dung lượng lớn, quản lý phức tạp hơn, tốc độ truy xuất chậm hơn Stack.
- Cơ chế: Khi dùng từ khóa new để tạo đối tượng kiểu Reference Type:
+ 1. Bộ nhớ được cấp phát trên Heap để chứa thông tin đối tượng.
+ 2. Địa chỉ của vùng nhớ đó được lưu lại vào một biến nằm trên Stack

-------------------------------------------------------------------------------------------------------------------------------------------
## Câu 2: Tính năng Init-only Properties (`init`) trong C# 9/10 khác gì `set` thông thường? Trường hợp sử dụng thực tế

- Khác biệt:
  - `set`: Cho phép gán/thay đổi giá trị của thuộc tính bất kỳ lúc nào trong suốt vòng đời của đối tượng.
  - `init`: Chỉ cho phép gán giá trị 1 lần duy nhất lúc khởi tạo đối tượng (qua Constructor hoặc Object Initializer). Sau khi khởi tạo xong, thuộc tính trở thành Read-only (chỉ đọc) và không thể sửa đổi từ bên ngoài.
- Trường hợp sử dụng thực tế:
  - Dùng khi thiết kế các đối tượng không thể thay đổi (Immutable Objects) hoặc Data Transfer Objects (DTO) cần đảm bảo tính toàn vẹn dữ liệu (ví dụ: `MaSV`, `MaPT`, `CMND` không được phép đổi sau khi khởi tạo).

----------------------------------------------------------------------------------------------------------------------------------------------


## Câu 3: Phân biệt `virtual` ở lớp cha và `override` ở lớp con khi triển khai Tính Đa hình (Polymorphism)

- `virtual` (ở lớp cha):
  - Cho phép phương thức ở lớp cha có triển khai mặc định, đồng thời đánh dấu phương thức đó **có thể bị ghi đè** bởi các lớp con kế thừa.
- override` (ở lớp con):
  - Khai báo ở lớp con để ghi đè/thay thế định nghĩa phương thức của lớp cha.
- Ý nghĩa đa hình: Khi gọi phương thức thông qua con trỏ lớp cha trỏ tới đối tượng lớp con (ví dụ: `PhuongTien pt = new OTo(...)`), C# sẽ kích hoạt cơ chế gán liên kết muộn (Late Binding) để gọi đúng phương thức `override` của lớp con tại thời điểm runtime.

----------------------------------------------------------------------------------------------------------------------------------------------


## Câu 4: Tại sao thành phần `static` trong Lớp không thể truy xuất thông qua thể hiện (Object Instance) tạo bằng `new`?

- Lý do:
  - Thành phần `static` (biến/phương thức tĩnh) thuộc về mức độ Lớp (Class level), được cấp phát bộ nhớ một lần duy nhất khi ứng dụng nạp Lớp đó vào bộ nhớ.
  - Đối tượng tạo bằng từ khóa `new` đại diện cho một thể hiện cụ thể (Instance level).
  - C# quy định truy xuất `static` phải thông qua `TenLop.TenThanhPhanStatic` để đảm bảo rõ ràng về mặt quản lý bộ nhớ và tránh nhầm lẫn dữ liệu riêng của thể hiện với dữ liệu dùng chung của cả lớp.


