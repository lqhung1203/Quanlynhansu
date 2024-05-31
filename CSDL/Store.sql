
---Them phong ban
go
	create proc sp_Themphongban
	@Ma_PB varchar(50),@Ten_PB nvarchar(255)
		as
		begin
			insert into PhongBan(PhongBan_ID,TenPhongBan) values (@Ma_PB,@Ten_PB)
		end
--Sửa phòng ban
go
 create proc sp_Suaphongban
	@Ma_PB varchar(50),@Ten_PB nvarchar(255)
	as
	begin
	update PhongBan set TenPhongBan = @Ten_PB where PhongBan_ID = @Ma_PB
	end
---Xóa phòng ban
	go
	create proc sp_Xoaphongban
	@Ma_PB varchar(50)
	as
	begin
	delete PhongBan where PhongBan_ID = @Ma_PB
	end
--------------------------------------------------------------------------------------------------------------------
GO 
CREATE PROC LayDSNhansu
AS
BEGIN
SELECT 
    ThongTinNhanSu.NhanVien_ID AS 'Mã Nhân Viên',
    ThongTinNhanSu.TenNhanVien AS 'Tên Nhân Viên',
    ThongTinNhanSu.NgaySinh AS 'Ngày Sinh',
    ThongTinNhanSu.GioiTinh AS 'Giới Tính',
    ThongTinNhanSu.DiaChi AS 'Địa Chỉ',
    ThongTinNhanSu.SoDienThoai AS 'Số Điện Thoại',
    ThongTinNhanSu.Email AS 'Email',
    PB.TenPhongBan AS 'Phòng Ban',
    CV.TenChucVu AS 'Chức Vụ',
    B.TenBHYT AS 'BHYT',
    HS.TenHeSo AS 'Hệ Số Lương'
FROM 
    ThongTinNhanSu
LEFT JOIN 
    PhongBan AS PB ON ThongTinNhanSu.PhongBan_ID = PB.PhongBan_ID
LEFT JOIN 
    ChucVu AS CV ON ThongTinNhanSu.ChucVu_ID = CV.ChucVu_ID
LEFT JOIN 
    BHYT AS B ON ThongTinNhanSu.BHYT_ID = B.BHYT_ID
LEFT JOIN 
    HeSoLuong AS HS ON ThongTinNhanSu.HeSo_ID = HS.HeSo_ID;
END
--drop proc LayDSNhansu
exec LayDSNhansu;
----XÓA NHÂN SỰ
GO
	CREATE PROC sp_XoaNhanSu
			@NhanVien_ID VARCHAR(50)
			AS
			BEGIN
			DELETE ThongTinNhanSu WHERE NhanVien_ID = @NhanVien_ID
			END
----THÊM NHÂN SỰ
GO
	CREATE PROCEDURE sp_ThemNhanSu
    @NhanVien_ID VARCHAR(50),
    @TenNhanVien NVARCHAR(255),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @DiaChi NVARCHAR(255),
    @SoDienThoai VARCHAR(15),
    @Email VARCHAR(255),
    @TenPhongBan NVARCHAR(255),
    @TenChucVu NVARCHAR(255),
    @TenBHYT NVARCHAR(255),
    @TenHeSo NVARCHAR(255)
AS
BEGIN
    -- Kiểm tra xem Nhân viên có tồn tại không
    IF NOT EXISTS (SELECT 1 FROM ThongTinNhanSu WHERE NhanVien_ID = @NhanVien_ID)
    BEGIN
        -- Thêm Nhân viên mới
        INSERT INTO ThongTinNhanSu (
            NhanVien_ID,
            TenNhanVien,
            NgaySinh,
            GioiTinh,
            DiaChi,
            SoDienThoai,
            Email,
            PhongBan_ID,
            ChucVu_ID,
            BHYT_ID,
            HeSo_ID
        )
        VALUES (
            @NhanVien_ID,
            @TenNhanVien,
            @NgaySinh,
            @GioiTinh,
            @DiaChi,
            @SoDienThoai,
            @Email,
            (SELECT PhongBan_ID FROM PhongBan WHERE TenPhongBan = @TenPhongBan),
            (SELECT ChucVu_ID FROM ChucVu WHERE TenChucVu = @TenChucVu),
            (SELECT BHYT_ID FROM BHYT WHERE TenBHYT = @TenBHYT),
            (SELECT HeSo_ID FROM HeSoLuong WHERE TenHeSo = @TenHeSo)
        );
    END
    ELSE
    BEGIN
        -- Nhân viên đã tồn tại, thực hiện hành động khác nếu cần
        PRINT 'Nhân viên đã tồn tại.';
    END
END;

-----SỬA NHÂN SỰ
GO
	CREATE PROCEDURE sp_SuaNhanSu
    @NhanVien_ID VARCHAR(50),
    @TenNhanVien NVARCHAR(255),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @DiaChi NVARCHAR(255),
    @SoDienThoai VARCHAR(15),
    @Email VARCHAR(255),
    @PhongBan_ID VARCHAR(50),
    @ChucVu_ID VARCHAR(50),
    @BHYT_ID VARCHAR(50),
    @HeSo_ID VARCHAR(50)
AS
BEGIN
 IF EXISTS (SELECT 1 FROM THONGTINNHANSU WHERE NhanVien_ID = @NhanVien_ID)
		-- Kiểm tra và cập nhật cho PhongBan_ID
	IF EXISTS (SELECT 1 FROM PhongBan WHERE PhongBan_ID = @PhongBan_ID)
			-- Kiểm tra và cập nhật cho ChucVu_ID
		IF EXISTS (SELECT 1 FROM ChucVu WHERE ChucVu_ID = @ChucVu_ID)
				-- Kiểm tra và cập nhật cho BHYT_ID
			IF EXISTS (SELECT 1 FROM BHYT WHERE BHYT_ID = @BHYT_ID)
					-- Kiểm tra và cập nhật cho HeSo_ID
				IF EXISTS (SELECT 1 FROM HeSoLuong WHERE HeSo_ID = @HeSo_ID)
					UPDATE ThongTinNhanSu
						SET
							TenNhanVien = @TenNhanVien,
							NgaySinh = @NgaySinh,
							GioiTinh = @GioiTinh,
							DiaChi = @DiaChi,
							SoDienThoai = @SoDienThoai,
							Email = @Email,
							PhongBan_ID = @PhongBan_ID,
							ChucVu_ID = @ChucVu_ID,
							BHYT_ID = @BHYT_ID,
							HeSo_ID = @HeSo_ID
						WHERE NhanVien_ID = @NhanVien_ID;
END
 exec sp_SuaNhanSu 'NV001',N'Lương Hùng','12/12/2003',N'Nam',N'Thủ Đức',0987992832,'hung@gmail.com','PB02','GD00','BH00','1'
		--drop proc sp_SuaNhanSu
-- Kiểm tra giá trị khóa ngoại trước khi thực hiện UPDATE
DECLARE @PhongBanID VARCHAR(50);

-- Đặt giá trị cần kiểm tra
SET @PhongBanID = 'PB01'

-- Kiểm tra xem giá trị có tồn tại trong bảng PhongBan không
IF NOT EXISTS (SELECT 1 FROM PhongBan WHERE PhongBan_ID = @PhongBanID)
BEGIN
    -- Nếu không tồn tại, in ra thông báo lỗi hoặc thực hiện các bước khác theo nhu cầu
    PRINT 'Lỗi: Giá trị không tồn tại trong bảng PhongBan';
END
ELSE
	BEGIN
    UPDATE ThongTinNhanSu
    SET PhongBan_ID = @PhongBanID
    WHERE NhanVien_ID = @NhanVien_ID
    PRINT 'Cập nhật thành công!';
END

---THÊM BHYT
GO
	CREATE PROC sp_ThemBHYT
	 @BHYT_ID VARCHAR(50),@TenBHYT NVARCHAR(255),@MoTa NVARCHAR(255)
	AS
	BEGIN
		INSERT INTO BHYT(BHYT_ID,TenBHYT,MoTa) VALUES(@BHYT_ID,@TenBHYT,@MoTa)
	END
---XÓA BHYT
GO
	CREATE PROC sp_XoaBHYT
		 @BHYT_ID VARCHAR(50)
	AS
	BEGIN
		DELETE BHYT WHERE BHYT_ID = @BHYT_ID
	END
---SỬA BHYT
GO
	CREATE PROC sp_SuaBHYT
		@BHYT_ID VARCHAR(50),@TenBHYT NVARCHAR(255),@MoTa NVARCHAR(255)
	AS
	BEGIN
	 UPDATE BHYT SET TenBHYT = @TenBHYT, MoTa = @MoTa WHERE BHYT_ID = @BHYT_ID
	END
	-------------------------------------------------------------------------------------
	----------------------------------------------------------------------------------------TÀI KHOẢN
GO
	CREATE PROC NSChuacoTK
	AS
	BEGIN
		SELECT ThongTinNhanSu.NhanVien_ID AS 'Mã Nhân Viên', ThongTinNhanSu.TenNhanVien AS'Tên Nhân Viên'
		FROM ThongTinNhanSu
		WHERE NhanVien_ID NOT IN (SELECT NhanVien_ID FROM TaiKhoan)
	END
	
GO 
	CREATE PROC NSCOTK
	AS
	BEGIN
		SELECT ThongTinNhanSu.NhanVien_ID,ThongTinNhanSu.TenNhanVien, TaiKhoan.TenDangNhap, TaiKhoan.MatKhau, TaiKhoan.LoaiTaiKhoan
		FROM ThongTinNhanSu
		JOIN TaiKhoan ON ThongTinNhanSu.NhanVien_ID = TaiKhoan.NhanVien_ID
	END
GO
	CREATE PROCEDURE sp_ThemTaiKhoan
		@TenDangNhap VARCHAR(255),
		@MatKhau VARCHAR(255),
		@LoaiTaiKhoan VARCHAR(20),
		@NhanVien_ID VARCHAR(50)
	AS
	BEGIN
		-- Tạo một giá trị mới cho TaiKhoanID
		DECLARE @NewTaiKhoanID VARCHAR(50);
		SET @NewTaiKhoanID = 'TK' + REPLACE(CONVERT(VARCHAR(36), NEWID()), '-', '');

		-- Thêm dữ liệu vào bảng TaiKhoan
		INSERT INTO TaiKhoan (TaiKhoanID, TenDangNhap, MatKhau, LoaiTaiKhoan, NhanVien_ID)
		VALUES (@NewTaiKhoanID, @TenDangNhap, @MatKhau, @LoaiTaiKhoan, @NhanVien_ID);
END;
GO
	CREATE PROC sp_XoaTaiKhoan
		@NhanVien_ID VARCHAR(50)
	AS
	BEGIN
		DELETE TaiKhoan WHERE NhanVien_ID = @NhanVien_ID
	END
GO
	CREATE PROC sp_SuaTaiKhoan
		@TenDangNhap VARCHAR(255),
		@MatKhau VARCHAR(255),
		@LoaiTaiKhoan VARCHAR(20),
		@NhanVien_ID VARCHAR(50)
	AS
	BEGIN
		UPDATE TaiKhoan SET TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, LoaiTaiKhoan = @LoaiTaiKhoan WHERE NhanVien_ID = @NhanVien_ID
	END


     