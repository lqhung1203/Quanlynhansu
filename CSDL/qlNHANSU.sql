CREATE DATABASE QLNhansuu
SET DATEFORMAT dmy
GO
	USE QLNhansuu
CREATE TABLE TinhTrangChamCong (
    TinhTrang_ID VARCHAR(50) PRIMARY KEY,
    TenTinhTrang NVARCHAR(255)
);
CREATE TABLE PhongBan (
    PhongBan_ID VARCHAR(50) PRIMARY KEY,
    TenPhongBan NVARCHAR(255))

CREATE TABLE ChucVu (
    ChucVu_ID VARCHAR(50) PRIMARY KEY,
    TenChucVu NVARCHAR(255),
);
CREATE TABLE HeSoLuong (
    HeSo_ID VARCHAR(50) PRIMARY KEY,
    TenHeSo NVARCHAR(255),
    HeSoLuong FLOAT);
CREATE TABLE BHYT (
    BHYT_ID VARCHAR(50) PRIMARY KEY,
    TenBHYT NVARCHAR(255),
    MoTa NVARCHAR(255));
CREATE TABLE ThongTinNhanSu (
    NhanVien_ID VARCHAR(50) PRIMARY KEY,
    TenNhanVien NVARCHAR(255),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(255),
    SoDienThoai VARCHAR(15),
    Email VARCHAR(255),
    PhongBan_ID VARCHAR(50),
    ChucVu_ID VARCHAR(50),
    BHYT_ID VARCHAR(50),
	HeSo_ID VARCHAR(50),
    FOREIGN KEY (PhongBan_ID) REFERENCES PhongBan(PhongBan_ID),
    FOREIGN KEY (ChucVu_ID) REFERENCES ChucVu(ChucVu_ID),
    FOREIGN KEY (BHYT_ID) REFERENCES BHYT(BHYT_ID),
	FOREIGN KEY (HeSo_ID) REFERENCES HeSoLuong(HeSo_ID))
CREATE TABLE ChamCong (
    ChamCong_ID VARCHAR(50) PRIMARY KEY,
    NgayChamCong DATE,
    NhanVien_ID VARCHAR(50),
	Tinhtrang NVARCHAR(50),
	TinhTrang_ID VARCHAR(50)
    FOREIGN KEY (NhanVien_ID) REFERENCES ThongTinNhanSu(NhanVien_ID),
	FOREIGN KEY (TinhTrang_ID) REFERENCES TinhTrangChamCong(TinhTrang_ID));
CREATE TABLE PhuCap (
    PhuCap_ID VARCHAR(50) PRIMARY KEY,
    TenPhuCap NVARCHAR(255),
    GiaTri FLOAT,
    MoTa NVARCHAR(255),
	NhanVien_ID VARCHAR(50),
    FOREIGN KEY (NhanVien_ID) REFERENCES ThongTinNhanSu(NhanVien_ID));
CREATE TABLE Luong (
    Luong_ID VARCHAR(50) PRIMARY KEY,
    NhanVien_ID VARCHAR(50),
    HeSoLuong_ID VARCHAR(50),
    ThangNam DATE,
    TongLuong FLOAT,
    FOREIGN KEY (NhanVien_ID) REFERENCES ThongTinNhanSu(NhanVien_ID),
    FOREIGN KEY (HeSoLuong_ID) REFERENCES HeSoLuong(HeSo_ID));
CREATE TABLE TaiKhoan (
    TaiKhoanID VARCHAR(50) PRIMARY KEY,
    TenDangNhap VARCHAR(255),
    MatKhau VARCHAR(255),
    LoaiTaiKhoan VARCHAR(20), -- Admin hoặc NhanVien
    NhanVien_ID VARCHAR(50),
    FOREIGN KEY (NhanVien_ID) REFERENCES ThongTinNhanSu(NhanVien_ID));
	------DỮ LIỆU HỆ SỐ LƯƠNG
go
	
insert into HeSoLuong(HeSo_ID,TenHeSo,HeSoLuong)
values('1',N'Bậc 1','40000000'),
('2',N'Bậc 2','5000000'),
('3',N'Bậc 3','7000000'),
('4',N'Bậc 4','9000000'),
('5',N'Bậc 5','10000000'),
('6',N'Bậc 6','12000000'),
('7',N'Bậc 7','15000000'),
('8',N'Bậc 8','19000000')
-----DỮ LIỆU CHỨC VỤ
insert into ChucVu(ChucVu_ID,TenChucVu)
values('GD00',N'Giám Đốc'),
('PGD00',N'Phó Giám Đốc'),('PP00',N'Phó Phòng'),('TP00',N'Trưởng Phòng'),('NV00',N'Nhân Viên')
----DỮ LIỆU PHÒNG BAN
insert into PhongBan(PhongBan_ID,TenPhongBan)
values('PB00',N'Phòng Giám Đốc'),
('PB01',N'Phòng Phó Giám Đốc'),
('PB02',N'Phòng Kế Toán'),
('PB03',N'Phòng Kinh Doanh'),
('PB04',N'Phòng Hành Chính')
----DỮ LIỆU BHYT
insert into BHYT(BHYT_ID ,TenBHYT,MoTa)
values('BH00','BHYT',N'TP HCM'),
('BH01','BHTN',N'Đà Nẵng'),
('BH02','BHCN',N'Hà Nội')
-----DỮ LIỆU PHỤ CẤP
insert into PhuCap(PhuCap_ID,TenPhuCap,GiaTri,MoTa)
values('PC00',N'Nhà ở',500000,'CB'),
('PC01',N'Đi lại',400000,'CB'),
('PC02',N'Thưởng tháng',1000000,'XS')
-----DỮ LIỆU CHẤM CÔNG
INSERT INTO ChamCong(ChamCong_ID,NgayChamCong,NhanVien_ID,Tinhtrang)
VALUES('C00','23/10/2022',NULL,N'Đi Muộn'),
('C01','10/09/2022',NULL,N'Về Sớm')
------DỮ LIỆU KHEN THƯỞNG
--insert into KhenThuong(KhenThuong_ID,TenKhenThuong,MoTa)
--values('KT00',N'Thưởng',N'Nhân viên xuất sắc'),
--('KT01',N'Phạt',N'Đi muộn,về sớm'),
--('KT02',N'Phạt',N'Đi muộn')
----DỮ LIỆU THÔNG TIN NHÂN SỰ
insert into ThongTinNhanSu(NhanVien_ID,TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,Email,PhongBan_ID,ChucVu_ID,BHYT_ID,HeSo_ID)
values('NV001',N'Lương Quốc Hùng','12/12/2003',N'Nam',N'Thủ Đức',0987992832,'hung@gmail.com','PB00','GD00','BH00','8'),
('NV002',N'Nguyễn Anh Tú','02/10/2000',N'Nam',N'Hà Nội',1231231122,'anhtu@gmail.com','PB00','GD00','BH00','5'),
('NV003',N'Nguyễn Bích Phương','03/02/1999',N'Nữ',N'Hà Nội',123412312,'phuong@gmail.com','PB02','PP00','BH02','7'),
('NV004',N'Nguyễn Văn Toàn','01/09/2000',N'Nam',N'TP HCM',1231231122,'toan@gmail.com','PB03','TP00','BH01','3'),
('NV005',N'Phạm Quốc Bảo','12/10/1989',N'Nam',N'Hà Nội',1231231122,'anhbao@gmail.com','PB02','TP00','BH00','4'),
('NV006',N'Lê Thị Thảo','10/02/2001',N'Nữ',N'Đà Nẵng',1231231122,'letaho@gmail.com','PB03','PGD00','BH02','2'),
('NV007', N'Nguyễn Văn Anh', '1990/01/01', 'Nam', 'TP HCM', 123456789, 'nv_a@email.com', 'PB04', 'NV00', 'BH02', '4'),
('NV008', N'Trần Thị Bưởi', '1995/02/15', N'Nữ', 'TP HCM', 987654321, 'nv_b@email.com', 'PB02', 'NV00', 'BH01', '3'),
('NV009', N'Lê Văn Chí', '1988/05/20', N'Nam', N'Hà Nội', 555666777, 'nv_c@email.com', 'PB03', 'NV00', 'BH02', '4'),
('NV010', N'Phạm Ngọc Duyên', '1993/11/10', N'Nữ', N'Đà Nẵng', 333222111, 'nv_d@email.com', 'PB04', 'NV00', 'BH02', '2'),
('NV011', N'Hòang Văn Lương', '1992/08/25', 'Nam', 'TP HCM', 456789012, 'nv_e@email.com', 'PB04', 'NV00', 'BH02', '4'),
('NV012', N'Nguyễn Thị Trang', '1987/03/18', N'Nữ', N'Hà Nội', 789012345, 'nv_f@email.com', 'PB04', 'NV00', 'BH02', '5'),
('NV013', N'Trần Hiếu Phúc', '1998/06/30', N'Nam', 'TP HCM', 123012301, 'nv_g@email.com', 'PB03', 'NV00', 'BH02', '3'),
('NV014', N'Lê Thị Thùy Trang', '1991/09/12', N'Nữ', N'Hà Nội', 654765476, 'nv_h@email.com', 'PB04', 'NV00', 'BH02', '4'),
('NV015', N'Phạm Văn Hiếu', '1985/11/05', N'Nam', 'TP HCM', 89345678, 'nv_i@email.com', 'PB04', 'NV00', 'BH02', '5'),
('NV016', N'Võ Thị Kiều', '1997/02/28', N'Nữ', N'Hà Nội', 234567890, 'nv_k@email.com', 'PB04', 'NV00', 'BH02', '3'),
('NV017', N'Đặng Văn Chiến', '1994/04/15', N'Nam', 'TP HCM', 890123456,'nv_l@email.com', 'PB03', 'NV00', 'BH02', '4'),
('NV018', N'Mai Thị Mùi','1989/07/08',N'Nu', N'Đà Nẵng', 456789012,'nv_m@email.com', 'PB04', 'NV00', 'BH02', '4'),
('NV019', N'Trương Văn Ngọc', '1996/10/22', N'Nam', N'Đà Nẵng', 987654321, 'nv_n@email.com', 'PB02', 'NV00', 'BH02', '5'),
('NV020', N'Ngô Thị Phương', '1990/12/05', N'Nữ', N'Đà Nẵng', 123456789, 'nv_p@email.com', 'PB03', 'NV00', 'BH00', '3');
----DỮ LIỆU LƯƠNG NHÂN SỰ
INSERT INTO Luong(Luong_ID,NhanVien_ID,HeSoLuong_ID,ThangNam,TongLuong)
VALUES('1','NV001','8','12/12/2019', 19000000),
('2','NV003','5','12/12/2019', 10000000),
('3','NV002','5','12/12/2019', 10000000)
-----Dữ Liệu Tinh Trạng
INSERT INTO TinhTrangChamCong (TinhTrang_ID, TenTinhTrang) VALUES
('1', 'Đi làm'),
('2', 'Nghỉ phép'),
('3', 'Nghỉ không lương');
------------------------TÀI KHOẢN
--DROP DATABASE QLNhansuu
