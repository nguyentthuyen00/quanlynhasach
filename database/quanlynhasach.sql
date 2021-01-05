
create database QLNHASACH
GO
use QLNHASACH
GO

Create Table NHACUNGCAP
(
	MaNCC varchar(6),
	TenNCC nvarchar(100) NOT NULL,
	Diachi NVARCHAR(250)NOT NULL unique,
	DienThoai NVARCHAR(20) NOT NULL unique,
	Email NVARCHAR(150),
	TienNo Money NOT NULL default 0, 
	CONSTRAINT PK_NhaCungCap PRIMARY KEY(MaNCC)
)
GO
-- Dữ liệu --
insert into NHACUNGCAP (MaNCC,TenNCC,Diachi,DienThoai,Email) values ('KD',N'Kim Đồng', N'55 Quang Trung, Hai Bà Trưng, Hà Nội','0243.943.4730','kimdong@hn.vnn.vn')
insert into NHACUNGCAP (MaNCC,TenNCC,Diachi,DienThoai,Email) values ('NN',N'Nhã Nam', N'59 - Đỗ Quang - Trung Hòa - Cầu Giấy - Hà Nội','0903244248','bookstore@nhanam.vn')
insert into NHACUNGCAP (MaNCC,TenNCC,Diachi,DienThoai) values ('TV',N'Trí  Việt',N'36/5 Đường Vĩnh Phú 20, P, Thuận An, Bình Dương','028 2214 8086')
insert into NHACUNGCAP (MaNCC,TenNCC,Diachi,DienThoai,Email) values ('ML',N'Minh Long',N'Số 378 Minh Khai, phường Vĩnh Tuy, quận Hai Bà Trưng, Hà Nội','024 7300 8377','minhlongbook@gmail.com')
insert into NHACUNGCAP (MaNCC,TenNCC,Diachi,DienThoai) values ('HHB',N'Huy Hoang Bookstore',N'110D Ngọc Hà, P. Đội Cấn, Q. Ba Đình, Hà Nội','043 7365859')
insert into NHACUNGCAP (MaNCC,TenNCC,Diachi,DienThoai,Email) values ('1980B',N'1980 Books',N'58/79 Nguyễn Minh Hoàng-Phường 12-Tân Bình, Quận 3, - TP.HCM','02839333216',' info@1980books.vn')
insert into NHACUNGCAP (MaNCC,TenNCC,Diachi,DienThoai,Email) values ('DA',N'Đông A',N'209 Võ Văn Tần, P.5, Q.3, Tp. Hồ Chí Minh', '(028) 3929 1286','Tdtdonga@gmail.com')

Create Table NHAXUATBAN
(
	MaNXB varchar(6),
	TenNXB nvarchar(100) NOT NULL unique,
	CONSTRAINT PK_NhaXuatBan PRIMARY KEY(MaNXB)
)


insert into NHAXUATBAN (MaNXB,TenNXB) values ('THHCM',N'NXB Tổng Hợp TP Hồ Chí Minh')
insert into NHAXUATBAN (MaNXB,TenNXB) values ('KD',N'NXB Kim Đồng')
insert into NHAXUATBAN (MaNXB,TenNXB) values ('HNV',N'NXB Hội Nhà Văn')
insert into NHAXUATBAN (MaNXB,TenNXB) values ('VH',N'NXB Văn Học')
insert into NHAXUATBAN (MaNXB,TenNXB) values ('DT',N'NXB Dân Trí')
insert into NHAXUATBAN (MaNXB,TenNXB) values ('LD',N'NXB Lao Động')
insert into NHAXUATBAN (MaNXB,TenNXB) values ('TG',N'NXB Thế Giới')
insert into NHAXUATBAN (MaNXB,TenNXB) values ('TN',N'NXB Thanh Niên')
insert into NHAXUATBAN (MaNXB,TenNXB) values ('KTQD',N'NXB Kinh Tế Quốc Dân')
insert into NHAXUATBAN (MaNXB,TenNXB) values ('ĐHSP',N'NXB Đại học Sư Phạm')
insert into NHAXUATBAN (MaNXB,TenNXB) values ('GDVN',N'NXB Đại học Giáo Dục Việt Nam')

/*
CREATE TABLE TACGIA
(
	MaTG INT IDENTITY(1,1),
	TenTG NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_TacGia PRIMARY KEY(MaTG)
)
insert into TACGIA (TenTG) values ('Gosho Aoyama')
insert into TACGIA (TenTG) values ('Fujiko.F.Fujio')
insert into TACGIA (TenTG) values ('Yoshito Usui')
insert into TACGIA (TenTG) values ('Kuroyanagi Tetsuko')
insert into TACGIA (TenTG) values ('Vương Diễm Nga')
insert into TACGIA (TenTG) values ('Antoine de Saint')
insert into TACGIA (TenTG) values ('Đức Anh (Sưu tầm, tuyển chọn)')
insert into TACGIA (TenTG) values ('Frances Hodgson Burnett')
insert into TACGIA (TenTG) values ('Antoine Galland')
*/

Create Table THELOAI
(
	MaTL varchar(6),
	TenTL nvarchar(100) NOT NULL unique,
	CONSTRAINT PK_TheLoai PRIMARY KEY(MaTL)
) 
insert into THELOAI (MaTL,TenTL) values ('TN',N'Thiếu Nhi')
insert into THELOAI (MaTL,TenTL) values ('VHTT',N'Văn học - Tiểu Thuyết')
insert into THELOAI (MaTL,TenTL) values ('GD',N'Giáo dục')
insert into THELOAI (MaTL,TenTL) values ('KT',N'Kinh Tế')
insert into THELOAI (MaTL,TenTL) values ('KHKT',N'Khoa học - Kỹ Thuật')
insert into THELOAI (MaTL,TenTL) values ('TT',N'Truyện Tranh')
insert into THELOAI (MaTL,TenTL) values ('DS',N'Đời Sống')
GO

CREATE TABLE SACH
(
	MaSach varchar(8),
	TenSach NVARCHAR(250) NOT NULL,
	TacGia nvarchar(200),
	MaNhaXB varchar(6) constraint FK_NXB foreign key references NHAXUATBAN(MaNXB),
	MaNhaCungCap varchar(6) constraint FK_NCC foreign key references NHACUNGCAP(MaNCC),
	MaTheLoai varchar(6) constraint FK_TheLoa foreign key references THELOAI(MaTL),
	GiaNhap MONEY CHECK (GiaNhap>=0),
	GiaBan MONEY CHECK (GiaBan>=0),
	DonViTinh NVARCHAR(50) DEFAULT N'cuốn',
	SoLuongTon INT default 0,
	Mota NTEXT,
	CONSTRAINT PK_Sach PRIMARY KEY(Masach)
)
GO

---Truyen Tranh --
--Conan--
insert into SACH (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('TTCN95', N'Thám Tử Lừng Danh Conan Tập 95','Gosho Aoyama','KD','KD','TT',10000,16000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('TTCN94',N'Thám Tử Lừng Danh Conan Tập 94','Gosho Aoyama','KD','KD','TT',10000,16000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('093',N'Thám Tử Lừng Danh Conan Tập 93','Gosho Aoyama','KD','KD','TT',10000,16000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('CN092',N'Thám Tử Lừng Danh Conan Tập 92','Gosho Aoyama','KD','KD','TT',10000,16000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('CN091',N'Thám Tử Lừng Danh Conan Tập 91','Gosho Aoyama','KD','KD','TT',10000,16000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('CN090',N'Thám Tử Lừng Danh Conan Tập 90','Gosho Aoyama','KD','KD','TT',10000,16000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan,DonViTinh) values ('CN195',N'Thám Tử Lừng Danh Conan Trọn bộ (1-95)','Gosho Aoyama','KD','KD','TT',1000000,1500000,'bộ')
--Doraemon--
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('DRD011',N'Doraemon Truyện Dài Tập 11 - Nobita Ở Xứ Sở Nghìn Lẻ Một Đêm','Fujiko.F.Fujio','KD','KD','TT',12000,18000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('DRD019',N'Doraemon Truyện Dài - Tập 19 - Nobita Vũ Trụ Phiêu Lưu Kí','Fujiko.F.Fujio','KD','KD','TT',12000,18000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('DRD012',N'Doraemon Truyện Dài - Tập 12 - Nobita Và Vương Quốc Trên Mây','Fujiko.F.Fujio','KD','KD','TT',12000,18000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('DRD017',N'Doraemon Truyện Dài - Tập 17 - Nobita Và Cuộc Phiêu Lưu Ở Thành Phố Dây Cót','Fujiko.F.Fujio','KD','KD','TT',12000,18000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('DRD021',N'Doraemon Truyện Dài - Tập 21 - Nobita Và Những Dũng Sĩ Có Cánh','Fujiko.F.Fujio','KD','KD','TT',12000,18000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('DRD016',N'Doraemon Truyện Dài - Tập 16 - Nobita Và Chuyến Tàu Tốc Hành Ngân Hà','Fujiko.F.Fujio','KD','KD','TT',12000,18000)
-- Shin --
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('S00044',N'Shin - Cậu Bé Bút Chì - Tập 44','Yoshito Usui','KD','KD','TT',12000,17000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('SDB004',N'Shin - Cậu Bé Bút Chì (Tập 4) - Bản Đặc Biệt','Yoshito Usui','KD','KD','TT',12000,17000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('SDB002',N'Shin - Cậu Bé Bút Chì (Tập 2) - Bản Đặc Biệt','Yoshito Usui','KD','KD','TT',12000,17000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('STD012',N'Shin - Cậu Bé Bút Chì (Truyện Dài) - Tập 12: Chuyến Thám Hiểm Vương Quốc Thần Tiên','Yoshito Usui','KD','KD','TT',14000,20000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('S00024',N'Shin - Cậu Bé Bút Chì - Tập 24','Yoshito Usui','KD','KD','TT',12000,17000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan,DonViTinh) values ('SCBDB8',N'Combo Shin Cậu Bé Bút Chì Bộ Đặc Biệt (8 cuốn)','Yoshito Usui','KD','KD','TT',85000,120000,'bộ')
--One piece --
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('OP0091',N'One Piece - Tập 91 (bìa rời)','Eiichiro Oda','KD','KD','TT',14000,20000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('OP0081',N'One Piece - Tập 81 (bìa rời)','Eiichiro Oda','KD','KD','TT',14000,20000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('OP0090',N'One Piece - Tập 90 (bìa rời)','Eiichiro Oda','KD','KD','TT',14000,20000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan,DonViTinh) values ('OPCB10',N'Combo One Piece - Tập 81-91 (10 cuốn)','Eiichiro Oda','KD','KD','TT',130000,180000,'bộ')
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('OPDB00',N'One Piece - Tập Đặc Biệt','Eiichiro Oda','KD','KD','TT',18000,23000)
-- Thiếu nhi --
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('TTCBCS',N'Totto-Chan Bên Cửa Sổ','Kuroyanagi Tetsuko','HNV','NN','TN',75000,98000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('101TCT',N'101 Truyện Cổ Tích Chọn Lọc',N'Vương Diễm Nga','VH','ML','TN',40000,65000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('HTB',N'Hoàng Tử Bé','Antoine de Saint – Exupéry','DT','HHB','TN',18000,25000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('10CHVS',N'10 Vạn Câu Hỏi Vì Sao?',N'Đức Anh (Sưu tầm, tuyển chọn)','DT','HHB','TN',29000,34000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('CCN',N'Công Chúa Nhỏ','Frances Hodgson Burnett','VH','DA','TN',65000,77000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan,DonViTinh) values ('NLMDTB',N'Nghìn Lẻ Một Đêm (trọn bộ 3 tập)','Antoine Galland','VH','DA','TN',212000,298000,'bộ')
-- Kinh tế --
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('TDPB',N'Tư Duy Phản Biện','Zoe McKey','TG','1980B','KT',75000,98000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('KN4.0',N'Khởi Nghiệp 4.0 - Kinh Doanh Thông Minh Trong Cách Mạng Công Nghiệp 4.0','Dorie Clark','LD','1980B','KT',75000,98000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('TKTD',N'Tiền Khôn Tiền Dại Ở Tay Người Dùng','Yuichiro Itakura','TN','ML','KT',75000,98000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('NTBDDT',N'Nghệ Thuật Bán Hàng Của Người Do Thái','Yaniv Zaid','THHCM','TV','KT',75000,98000)
--Đời sống --
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('DDTD&DN',N'Để Được Trọng Dụng & Đãi Ngộ','Brian Tracy','THHCM','TV','DS',75000,98000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('TDSS',N'Tư Duy Song Song','Edward de Bono','KTQD','1980B','DS',75000,98000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('KNLDHQ',N'Kỹ Năng Lãnh Đạo Hiệu Quả','Martin Lanik','KTQD','1980B','DS',75000,98000)
insert into SACH  (MaSach,TenSach,TacGia,MaNhaXB,MaNhaCungCap,MaTheLoai,GiaNhap,GiaBan) values ('KANSCTH',N'Khéo Ăn Nói Sẽ Có Được Thiên Hạ',N'Trác Nhã','VH','ML','DS',75000,98000)
--Văn học - Tiêu thuyết --

SELECT * FROM SACH
GO

/*---Dữ liệu sách --

 Truyện tranh: 'Thám Tử Lừng Danh Conan Tập 95' - Gosho Aoyama - Kim đồng - 
				'Doremon - Nobita Và Cuộc Phiêu Lưu Ở Thành Phố Dây Cót'- Fujiko.F.Fujio 
				'Shin - Cậu Bé Bút Chì' - Yoshito Usui
				'One piece' - Eiichiro Oda 
Thiếu nhi       'Totto-Chan Bên Cửa Sổ' - Kuroyanagi Tetsuko - NXB Hội Nhà Văn - Nhã Nam 
				'101 Truyện Cổ Tích Chọn Lọc' - Vương Diễm Nga - NXB Văn Học - Minh Long
				'Hoàng Tử Bé' - Antoine de Saint – Exupéry - Nhà Xuất Bản Dân Trí - Huy Hoang Bookstore 
				'10 Vạn Câu Hỏi Vì Sao?' - Đức Anh (Sưu tầm, tuyển chọn) - Nhà Xuất Bản Dân Trí - Huy Hoang Bookstore 
				'Công Chúa Nhỏ' - Frances Hodgson Burnett - NXB Văn Học - Đông A
				'Nghìn Lẻ Một Đêm' - Antoine Galland - NXB Văn Học - Đông A
Kinh tế:       'Tư Duy Phản Biện' - Zoe McKey -Nhà Xuất Bản Thế Giới - 1980 Books 
				'Khởi Nghiệp 4.0 - Kinh Doanh Thông Minh Trong Cách Mạng Công Nghiệp 4.0' - Dorie Clark - NXB Lao Động - 1980 Books 
				'Tiền Khôn Tiền Dại Ở Tay Người Dùng' - Yuichiro Itakura - NXB Thanh Niên - Minh Long
				'Nghệ Thuật Bán Hàng Của Người Do Thái' - Yaniv Zaid - Nhà Xuất Bản Tổng hợp TP.HCM  - Trí Việt
Đời sống:  'Để Được Trọng Dụng & Đãi Ngộ' - Brian Tracy - Nhà Xuất Bản Tổng hợp TP.HCM - - Trí Việt 
			'Tư Duy Song Song' - Edward de Bono -  Nhà Xuất Bản Đại Học Kinh Tế Quốc Dân - 1980 Books 
			'Kỹ Năng Lãnh Đạo Hiệu Quả' - Martin Lanik -  Nhà Xuất Bản Đại Học Kinh Tế Quốc Dân - 1980 Books 
			'Khéo Ăn Nói Sẽ Có Được Thiên Hạ ' - Trác Nhã - Nhà Xuất Bản Văn Học - Minh Long
Văn học - Tiểu thuyết :
				'Thú Tội' - Minato Kanae - Nhà Xuất Bản Hội Nhà Văn - Nhã Nam
				'Hai Số Phận' - Jeffrey Archer - NXB Văn Học - Huy Hoang Bookstore
				'Bắt Trẻ Đồng Xanh' - J. D. Salinger -  Nhà Xuất Bản Hội Nhà Văn - Nhã Nam
				'Tuổi Trẻ Đáng Giá Bao Nhiêu ' - Rosie Nguyễn -  NXB Hội Nhà Văn - Nhã Nam 
				'Mình Nói Gì Khi Nói Về Hạnh Phúc?  ' - Rosie Nguyễn -  NXB Hội Nhà Văn - Nhã Nam 
				'Không Gia Đình' - Hector Malot - NXB Văn Học - Đông A
Giáo dục: 
			'Bé vào lớp 1 - Bé tập đếm và tập tô' - Lê Tuệ Minh, Lê Thu Ngọc - NXB Đại Học Sư Phạm - Minh Long
			'Chuẩn bị cho bé vào lớp 1 (Túi 10 Cuốn)' - Lê Tuệ Minh, Lê Thu Ngọc - NXB Đại Học Sư Phạm - Minh Long
			'Đại Học Không Lạc Hướng' - Lý Thượng Long - NXB Thanh Niên  -  Minh Long  
			'Mai em vào Lớp 1 - Vở tập tô nét cơ bản ( 5 - 6T)' - Lê Hồng Đăng, Lê Thị Ngọc Ánh  - NXB Đại Học Sư Phạm - Minh Long
			'Từ Điển Anh - Việt Bằng Hình: Shapes - Hình Khối' - Đông A - NXB Dân Trí - Đông A
			'TTừ Điển Anh - Việt Bằng Hình: Alphabet - Bảng Chữ Cái' - Đông A - NXB Dân Trí - Đông A
Khoa học - Kỹ Thuật:
			'Bách Khoa Động Vật' - Karen Mc.Ghee - NXB Dân Trí - Đông A
			'Bách khoa toàn thư về không gian' - Nhiều tác giả - NXB Lao Động - Đông A
			'Khoa học môi trường' - Nhiều tác giả - NXB GIÁO Dục VN -  Đông A
			'Lịch Việt Nam thế kỷ XX - XXI (1901-2100) & niên biểu lịch sử Việt Nam' Nhiều tác giả - NXB GIÁO dục VN - Đông A
			'Nha khoa cơ sở Tập 1' - Nhiều tác giả - - NXB GIÁO dục VN - Đông A
			'Nha khoa cơ sở Tập 3' - Nhiều tác giả - - NXB GIÁO dục VN - Đông A
				*/

				Select DISTINCT TacGia from SACH
CREATE TABLE NHANVIEN
(
	MaNV varchar(8),
	HoTenNV NVarchar(100) NOT NULL,
	Diachi nVarchar(200),
	SDT Varchar(20) Not null,
	GioiTinh bit default 0,--0 nam, 1 nu--
	NgaySinh smalldatetime check(year(NgaySinh)<2020),
	NgayVaoLam smalldatetime,
	Email Varchar(50),
	CONSTRAINT PK_NHANVIEN PRIMARY KEY(MaNV)
)
GO

insert into NHANVIEN(MaNV, HoTenNV, SDT, GioiTinh, NgaySinh, NgayVaoLam) values ('18520189',N'Kiều Nguyễn Lang Vân', '03876775240', '1', '2000-01-25 00:00:00','2019-06-22 23:11:42')
insert into NHANVIEN(MaNV, HoTenNV, SDT, GioiTinh, NgaySinh, NgayVaoLam) values ('18520863',N'Nguyễn Thị Thu Huyền', '0968294003', '1', '2000-01-25 00:00:00','2019-06-22 23:11:42')
GO


CREATE TABLE HOADON
(
	MaHD varchar(10),
	NgayLap SMALLDATETIME,
	TongTien Money Check (TongTien>=0) default 0 ,
	NguoiLap varchar(8) constraint FK_NVlapHD foreign key references NHANVIEN(MaNV),
	CONSTRAINT PK_HoaDon PRIMARY KEY(MaHD)
)
GO

CREATE TABLE CT_HOADON
(
	MaHD varchar(10) constraint FK_HD foreign key references HOADON(MaHD),
	MaSach varchar(8) constraint FK_HD_Sach foreign key references SACH(MaSach),
	Soluong Int Check(Soluong>0),
	Dongia Decimal(9,2) Check(Dongia>=0),
	Thanhtien AS SoLuong*Dongia ,
	CONSTRAINT PK_CTHoaDon PRIMARY KEY(MaHD,MaSach)
)
GO

CREATE TABLE PhieuNhapSach
(
	MaPhieu varchar(10),
	NgayLap SMALLDATETIME,
	TongTien Money Check (TongTien>=0) default 0,
	DaTra Money,
	ConNo as TongTien - DaTra,
	NhaCungCap varchar(6) constraint FK_NCCPhieuNhap foreign key references NHACUNGCAP(MaNCC),
	NguoiLap varchar(8) constraint FK_NVPhieuNhap foreign key references NHANVIEN(MaNV),
	CONSTRAINT PK_PhieuNhapSach  PRIMARY KEY(MaPhieu),
)
GO

CREATE TABLE CT_PhieuNhapSach
(
	MaPhieu varchar(10) constraint FK_PhieuNhap foreign key references PhieuNhapSach(MaPhieu),
	MaSach varchar(8) constraint FK_PhieuNhap_Sach foreign key references SACH(MaSach),
	Soluong Int Check(Soluong>0),
	GiaNhap Decimal(9,2) Check(GiaNhap>=0),
	Thanhtien AS SoLuong*GiaNhap,
	CONSTRAINT PK_CTPNS PRIMARY KEY(MaPhieu,MaSach)
)
GO

CREATE TABLE KHUYENMAI
(
	MaKM varchar(12),
	NgayBatDau SMALLDATETIME,
	NgayKetThuc SMALLDATETIME,
	Ten NVARCHAR(100) NOT NULL,
	ChiTiet Text,
	CONSTRAINT PK_KhuyenMai PRIMARY KEY(MaKM)
)
GO

CREATE TABLE CT_KHUYENMAI
(
	MaKM varchar(12) constraint FK_KM foreign key references KHUYENMAI(MaKM),
	MaSach varchar(8) constraint FK_KM_Sach foreign key references SACH(MaSach),
	GiaKhuyenMai Money,
	CONSTRAINT PK_DonDatHang PRIMARY KEY(MaKM,MaSach)
)
GO
CREATE TABLE QUYDINH
(
	MAQD INT IDENTITY(1,1) , 
	TonToiDa INT NOT NULL default 300,
	TonToiThieu INT NOT NULL default 20,
	NhapToiThieu INT default 150,
	CONSTRAINT PK_QD PRIMARY KEY(MAQD)
)
GO

CREATE TABLE BAOCAOTON
(
	MaBaoCao INT IDENTITY(1,1),
	LoaiBC INT default 0, -- tháng, năm -- 
	NgayLap SMALLDATETIME,
	NguoiLap varchar(8) constraint FK_NVLBCTon foreign key references NHANVIEN(MaNV),
	MaSach varchar(8) constraint FK_BCTon_Sach foreign key references SACH(MaSach),
	TonDau INT,
	TonCuoi INT,
	PhatSinh INT,
	CONSTRAINT PK_BCTon PRIMARY KEY(MaBaoCao)
)
GO

CREATE TABLE BAOCAONO
(
	Thang INT,
	Nam INT,
	NgayLap SMALLDATETIME,
	NguoiLap varchar(8) constraint FK_NVlapBCNo foreign key references NHANVIEN(MaNV),
	MaNhaCungCap varchar(6) constraint FK_NCC_BCNo foreign key references NHACUNGCAP(MaNCC),
	NoCu money,
	PhatSinh money,
	NoMoi money,
	CONSTRAINT PK_BCNo PRIMARY KEY(Thang,Nam)
)
GO
--- Phân quyền tài khoản đăng nhâp --
CREATE TABLE TAIKHOAN
(
	IDTaiKhoan int IDENTITY(1,1) PRIMARY KEY ,
	TenHienThi nvarchar(50),
	TaiKhoan Varchar(20) NOT NULL UNIQUE,
	MatKhau varchar(20) NOT NULL,
	LoaiTaiKhoan  int NOT NULL,
	ThongTinTaiKhoan varchar(8) constraint FK_TK_TT foreign key references NHANVIEN(MaNV)
)
GO

insert into TAIKHOAN (TenHienThi,TaiKhoan,MatKhau,LoaiTaiKhoan,ThongTinTaiKhoan) values (N'Lang Vân','KNLV2501','25012000',1,'18520189')
insert into TAIKHOAN (TenHienThi,TaiKhoan,MatKhau,LoaiTaiKhoan,ThongTinTaiKhoan) values (N'Thu Huyền','NguyenHuyen','12112000',0,'18520863')

go
-- TRIGGER --
--1.Tính Tongtien Hóa đơn -- 
-- INSERT 1 CT_HOADON mới thì TongTien trong HOADON TĂNG, số lượng sách trong kho sẽ giảm = số lượng trong kho - số lượng bán --- 

CREATE TRIGGER TRG_INS_CTHD ON CT_HOADON 
FOR INSERT 
AS BEGIN 
	UPDATE HOADON SET TongTien = TongTien  + I.ThanhTien
	FROM INSERTED I 
	WHERE I.MAHD=HOADON.MaHD
	UPDATE SACH SET SoLuongTon= SoLuongTon - I.Soluong
	FROM INSERTED I 
	WHERE I.MaSach=SACH.MaSach 
END 

-- DELETE 1 CT_HOADON mới thì TongTien trong HOADON giảm , số lượng sách trong kho sẽ tăng về lại --- 

CREATE TRIGGER TRG_DEL_CTHD ON CT_HOADON FOR DELETE 
AS BEGIN 
UPDATE HOADON SET TongTien = TongTien  - D.ThanhTien 
FROM DELETED D 
WHERE HOADON.MaHD=D.MAHD 
UPDATE SACH SET SoLuongTon= SoLuongTon + I.Soluong
	FROM INSERTED I 
	WHERE I.MaSach=SACH.MaSach 
END 
--3. Xóa 1 Hóa đơn thì xóa các chi tiết hóa đơn cuar nó-- 
CREATE TRIGGER TRG_DEL_HOADON ON HOADON 
FOR DELETE 
AS BEGIN 
	DECLARE @MAHD int 
	SELECT @MAHD = MaHD
	FROM DELETED D
	delete from CT_HOADON
	where CT_HOADON.MaHD = @MAHD
END 


--2.Tính TongTien Phiếu Nhập Sách và cập nhật số lượng sách trong kho khi nhập sách  -- 
	--- INSERT 1 CT_PhieuNhapSach   mới thì TongTien trong PhieuNhapSach   TĂNG đồng thời tăng  số lượng sách trong kho = số lượng trong kho + số lượng nhập--- 

CREATE TRIGGER TRG_INS_CTNHAPSACH  ON CT_PhieuNhapSach 
FOR INSERT 
AS BEGIN 
	UPDATE PhieuNhapSach SET TongTien = TongTien  + I.ThanhTien
	FROM INSERTED I 
	WHERE I.MaPhieu=PhieuNhapSach.MaPhieu 
	UPDATE SACH SET SoLuongTon= SoLuongTon + I.Soluong
	FROM INSERTED I 
	WHERE I.MaSach=SACH.MaSach 
END 

	--- DELETE 1 1 CT_PhieuNhapSach   mới thì TongTien trong PhieuNhapSachGiảm  đồng thời giảm về lại  số lượng sách trong kho ban đầu--- 

CREATE TRIGGER TRG_DEL_CTNHAPSACH ON CT_PhieuNhapSach
FOR DELETE 
AS BEGIN 
UPDATE PhieuNhapSach SET TongTien = TongTien  - D.ThanhTien 
FROM DELETED D 
WHERE D.MaPhieu=PhieuNhapSach.MaPhieu 
UPDATE SACH SET SoLuongTon= SoLuongTon - I.Soluong
	FROM INSERTED I 
	WHERE I.MaSach=SACH.MaSach 
END 

--3.Cập nhật nợ của nhà cung cấp  khi nhập sách --
	-- Thêm 1 Phiếu nhập --
CREATE TRIGGER TRG_INS_NHAPSACH ON PhieuNhapSach 
FOR INSERT, Update  
AS BEGIN 
	UPDATE NHACUNGCAP SET TienNo = TienNo  + I.ConNo 
	FROM INSERTED I 
	WHERE I.NhaCungCap=NHACUNGCAP.MaNCC 
END 
	-- Xóa 1 phiếu nhập Xóa các CT_NhapSach liên quan và cập nhật lại tiền nợ,chỉ  xóa khi đã tạo thành công nhưng muốn hủy ko nhập nữa ! --
CREATE TRIGGER TRG_DEL_NHAPSACH ON PhieuNhapSach 
FOR DELETE 
AS BEGIN 
	DECLARE @MAPhieu int,  @TienNo money , @MANCC int 
	SELECT @MAPhieu = MaPhieu, @TienNo=ConNo, @MANCC=NhaCungCap
	FROM DELETED D 
	UPDATE NHACUNGCAP SET TienNo = TienNo  - @TienNo
	WHERE @MANCC=NHACUNGCAP.MaNCC
	DELETE from CT_PhieuNhapSach
	Where @MAPhieu  = CT_PhieuNhapSach.MaPhieu
END 


--2.Xóa khuyến mãi -> xóa các thông tin liên quan --
--3.Xóa phiếu nhập sách => xóa các thông tin liên quan --
--4.Kiểm tra xem nhập sách có đúng qui định ko : số lượng sách nhập tối thiểu, số lượng sách tồn kho --
--5.Kiểmm tra bán sách có đúng qui định: số lượng trong kho còn đur bán hay ko? --
--- Tìm kiếm sách --
--- Tìm kiếm sách theo mã, tên , tác giả, nhà cung cấp, nhà xuất bản, thể loại --
-- Tìm kiếm nhà cung cấp--
-- Tìm kiếm khuyễn mãi --
-- Tính tiền hóa đơn khi áp dụng mã khuyến mãi --
-- Thống kê hóa đơn, doanh số nhân viên bán được theo ngày, tuần , tháng --
-- Thống kê nợ --
-- Thống kê tồn kho --
-- Set nợ của nhà cung cấp về 0 khi admin thanh toán hết nợ -- 