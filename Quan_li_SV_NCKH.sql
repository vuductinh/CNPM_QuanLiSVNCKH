--code tạo bảng
create database quan_li_sinh_vien_NCKH
go
use quan_li_sinh_vien_NCKH
go
create table Khoa
(
	 Makhoa char(10) primary key,
	 Tenkhoa nvarchar(50)
)
go
create table BoMon
(
	Mabomon char(10) primary key,
	tenbomon nvarchar(50),
	Makhoa char(10)
	foreign key(Makhoa) references dbo.Khoa(Makhoa)
)
go
create table LopSH
(
    MalopSH char(10) primary key,
	Tenlopsh nvarchar(50),
	Makhoa char(10)
	foreign key(Makhoa) references dbo.Khoa(Makhoa)
)
go
create table SinhVien
(
    MaSV char(10) primary key,
	TenSV nvarchar(50),
	NgaySinh date,
	Diachi nvarchar(50),
	gioitinh nvarchar(50),
	MalopSH char(10)
	foreign key(MalopSH) references dbo.LopSH(MalopSH)
)
go
create table GiaoVien
(
    MaGV char(10) primary key,
	TenGV nvarchar(50),
	NgaysinhGV date,
	gioitinhGV nvarchar(50),
	Mabomon char(10)
	foreign key(Mabomon) references dbo.BoMon(Mabomon)
)
go
create table ChuyenNganh
(
    MaCN char(10) primary key,
	tenCN nvarchar(50),
	Mabomon char(10)
	foreign key(Mabomon) references dbo.BoMon(Mabomon)
)
go
create table DetaiNCKH
( 
    Madetai char(10) primary key,
	tendetai nvarchar(50),
	noidung nvarchar(100),
	ngaybd date,
	ngaykt date,
	ketqua nvarchar(50),
	MaGV char(10)
	foreign key(MaGV) references dbo.GiaoVien(MaGV),
	MaCN char(10)
	foreign key(MaCN) references dbo.ChuyenNganh(MaCN)
)
go
use quan_li_sinh_vien_NCKH
go
create table QuanliTH
(
 MaSV char(10),
 Madetai char(10),
 NDthuchien nvarchar(100),
 ketqua nvarchar(50),
 vaitro nvarchar(50)
 primary key(MaSV,Madetai)
)

go
alter table dbo.QuanliTH add foreign key(MaSV) references dbo.SinhVien(MaSV)
alter table dbo.QuanliTH add foreign key(Madetai) references dbo.DetaiNCKH(Madetai)
go
create table TienDoTH
(
   MaTD char(10) primary key,
   ketquaTD int,
   Madetai char(10)
   foreign key(Madetai) references dbo.DetaiNCKH(Madetai)
)
create table Taikhoan
(
tentaikhoan nvarchar(200) primary key,
matkhau char(50)
)
go


--insert dữ liệu
INSERT [dbo].[BoMon] ([Mabomon], [tenbomon], [Makhoa]) VALUES (N'BM01      ', N'Công nghệ phần mềm', N'MK01      ')
INSERT [dbo].[BoMon] ([Mabomon], [tenbomon], [Makhoa]) VALUES (N'BM02      ', N'Hệ thống thông tin', N'MK01      ')
INSERT [dbo].[BoMon] ([Mabomon], [tenbomon], [Makhoa]) VALUES (N'BM03      ', N'Kỹ thuật Vi Xử lý', N'MK02      ')
INSERT [dbo].[BoMon] ([Mabomon], [tenbomon], [Makhoa]) VALUES (N'BM04      ', N'Đo lường-Lý thuyết ạcch', N'MK02      ')
INSERT [dbo].[BoMon] ([Mabomon], [tenbomon], [Makhoa]) VALUES (N'BM05      ', N'Nhiệt thủy khí', N'MK03      ')
INSERT [dbo].[BoMon] ([Mabomon], [tenbomon], [Makhoa]) VALUES (N'BM06      ', N'Kỹ Thuật Ô tô', N'MK03      ')

INSERT [dbo].[ChuyenNganh] ([MaCN], [tenCN], [Mabomon]) VALUES (N'CN01      ', N'Chuyên Ngành A', N'BM01      ')
INSERT [dbo].[ChuyenNganh] ([MaCN], [tenCN], [Mabomon]) VALUES (N'CN02      ', N'Chuyên Ngành B', N'BM01      ')
INSERT [dbo].[ChuyenNganh] ([MaCN], [tenCN], [Mabomon]) VALUES (N'CN03      ', N'Chuyên Ngành C', N'BM02      ')
INSERT [dbo].[ChuyenNganh] ([MaCN], [tenCN], [Mabomon]) VALUES (N'CN04      ', N'Chuyên Ngành D', N'BM02      ')
INSERT [dbo].[ChuyenNganh] ([MaCN], [tenCN], [Mabomon]) VALUES (N'CN05      ', N'Chuyên Nhành E', N'BM03      ')
INSERT [dbo].[ChuyenNganh] ([MaCN], [tenCN], [Mabomon]) VALUES (N'CN06      ', N'Chuyên Ngành F', N'BM03      ')
INSERT [dbo].[ChuyenNganh] ([MaCN], [tenCN], [Mabomon]) VALUES (N'CN07      ', N'Chuyên Ngành G ', N'BM04      ')
INSERT [dbo].[ChuyenNganh] ([MaCN], [tenCN], [Mabomon]) VALUES (N'CN08      ', N'Chuyên Ngành H', N'BM04      ')
INSERT [dbo].[ChuyenNganh] ([MaCN], [tenCN], [Mabomon]) VALUES (N'CN09      ', N'Chuyên Ngành AB', N'BM05      ')
INSERT [dbo].[ChuyenNganh] ([MaCN], [tenCN], [Mabomon]) VALUES (N'CN10      ', N'Chuyên Ngành O', N'BM05      ')
INSERT [dbo].[ChuyenNganh] ([MaCN], [tenCN], [Mabomon]) VALUES (N'CN11      ', N'Chuyên Ngành I', N'BM06      ')
INSERT [dbo].[ChuyenNganh] ([MaCN], [tenCN], [Mabomon]) VALUES (N'CN12      ', N'Chuyên Ngành K', N'BM06      ')

INSERT [dbo].[DetaiNCKH] ([Madetai], [tendetai], [noidung], [ngaybd], [ngaykt], [ketqua], [MaGV], [MaCN]) VALUES (N'DT01      ', N'Đề Tài A', N'AB', CAST(N'2018-09-07' AS Date), CAST(N'1998-11-07' AS Date), N'Đạt', N'GV01      ', N'CN01      ')
INSERT [dbo].[DetaiNCKH] ([Madetai], [tendetai], [noidung], [ngaybd], [ngaykt], [ketqua], [MaGV], [MaCN]) VALUES (N'DT02      ', N'Đề Tài B', N'AC', CAST(N'2018-08-05' AS Date), CAST(N'2018-10-05' AS Date), N'Đạt', N'GV03      ', N'CN04      ')
INSERT [dbo].[DetaiNCKH] ([Madetai], [tendetai], [noidung], [ngaybd], [ngaykt], [ketqua], [MaGV], [MaCN]) VALUES (N'DT03      ', N'Đề tài C', N'BC', CAST(N'2018-09-03' AS Date), CAST(N'2018-11-05' AS Date), N'Đạt', N'GV05      ', N'CN11      ')
INSERT [dbo].[DetaiNCKH] ([Madetai], [tendetai], [noidung], [ngaybd], [ngaykt], [ketqua], [MaGV], [MaCN]) VALUES (N'DT04      ', N'Đề tài D', N'CE', CAST(N'2018-10-20' AS Date), CAST(N'2002-12-23' AS Date), N'Chưa Đạt', N'GV02      ', N'CN05      ')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaysinhGV], [gioitinhGV], [Makhoa], [Mabomon]) VALUES (N'GV01      ', N'Nguyễn Văn A', CAST(N'1975-04-30' AS Date), N'Nam', N'MK01      ', N'BM01      ')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaysinhGV], [gioitinhGV], [Makhoa], [Mabomon]) VALUES (N'GV02      ', N'Nguyễn Thị B', CAST(N'1976-05-05' AS Date), N'Nữ', N'MK01      ', N'BM02      ')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaysinhGV], [gioitinhGV], [Makhoa], [Mabomon]) VALUES (N'GV03      ', N'Trần Văn A', CAST(N'1974-08-09' AS Date), N'Nam', N'MK02      ', N'BM03      ')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaysinhGV], [gioitinhGV], [Makhoa], [Mabomon]) VALUES (N'GV04      ', N'Phạm Thị C', CAST(N'1971-12-15' AS Date), N'Nữ', N'MK02      ', N'BM04      ')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaysinhGV], [gioitinhGV], [Makhoa], [Mabomon]) VALUES (N'GV05      ', N'Đặng Thị X', CAST(N'1977-03-08' AS Date), N'Nữ', N'MK03      ', N'BM05      ')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaysinhGV], [gioitinhGV], [Makhoa], [Mabomon]) VALUES (N'GV06      ', N'Nguyễn Thị H', CAST(N'1980-10-09' AS Date), N'Nữ', N'MK03      ', N'BM06      ')

INSERT [dbo].[Khoa] ([Makhoa], [Tenkhoa]) VALUES (N'          ', N'')
INSERT [dbo].[Khoa] ([Makhoa], [Tenkhoa]) VALUES (N'MK01      ', N'Công nghệ thông tin')
INSERT [dbo].[Khoa] ([Makhoa], [Tenkhoa]) VALUES (N'MK02      ', N'Vô Tuyến Điện Tử')
INSERT [dbo].[Khoa] ([Makhoa], [Tenkhoa]) VALUES (N'MK03      ', N'Cơ Khí')

INSERT [dbo].[LopSH] ([MalopSH], [Tenlopsh], [Makhoa]) VALUES (N'SH01      ', N'Khoa Học Máy Tính', N'MK01      ')
INSERT [dbo].[LopSH] ([MalopSH], [Tenlopsh], [Makhoa]) VALUES (N'SH02      ', N'Mạng Máy Tính', N'MK01      ')
INSERT [dbo].[LopSH] ([MalopSH], [Tenlopsh], [Makhoa]) VALUES (N'SH03      ', N'Điện Tử Viễn Thông-1', N'MK02      ')
INSERT [dbo].[LopSH] ([MalopSH], [Tenlopsh], [Makhoa]) VALUES (N'SH04      ', N'Điện Tử Viễn Thông-2', N'MK02      ')
INSERT [dbo].[LopSH] ([MalopSH], [Tenlopsh], [Makhoa]) VALUES (N'SH05      ', N'Ô tô', N'MK03      ')
INSERT [dbo].[LopSH] ([MalopSH], [Tenlopsh], [Makhoa]) VALUES (N'SH06      ', N'Chế Tạo Máy', N'MK03      ')
use quan_li_sinh_vien_NCKH
go
 
select * from dbo.QuanliTH

INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [Diachi], [Gioitinh], [MalopSH]) VALUES (N'SV01      ', N'Vũ Đức Tỉnh', CAST(N'1997-03-25' AS Date), N'Nam Định',N'Nam', N'SH06      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [Diachi], [Gioitinh], [MalopSH]) VALUES (N'SV02      ', N'Nguyễn Chiến Thắng', CAST(N'1998-03-11' AS Date), N'Vĩnh Phúc', N'Nam', N'SH04      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [Diachi], [Gioitinh], [MalopSH]) VALUES (N'SV03      ', N'Đỗ Công Minh', CAST(N'1997-05-24' AS Date), N'Thái Bình', N'Nam', N'SH01      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [Diachi], [Gioitinh], [MalopSH]) VALUES (N'SV04      ', N'Nguyễn Đức Anh', CAST(N'1998-04-07' AS Date), N'Hà Nội',N'Nam' , N'SH02      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [Diachi], [Gioitinh], [MalopSH]) VALUES (N'SV05      ', N'Kim Quang Minh', CAST(N'1998-09-30' AS Date), N'Hà Nội', N'Nam', N'SH03      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [Diachi], [Gioitinh], [MalopSH]) VALUES (N'SV06      ', N'Phạm Thị Loan', CAST(N'1998-03-27' AS Date), N'Ninh Bình', N'Nữ', N'SH02      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [Diachi], [Gioitinh], [MalopSH]) VALUES (N'SV07      ', N'Hạ Thị Phượng', CAST(N'1997-07-07' AS Date), N'Hà Nội', N'Nữ', N'SH03      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [Diachi], [Gioitinh], [MalopSH]) VALUES (N'SV08      ', N'Nguyễn Thị Kim Ngân', CAST(N'1998-08-16' AS Date), N'Hà Nội', N'Nữ', N'SH01      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [Diachi], [Gioitinh], [MalopSH]) VALUES (N'SV09      ', N'Dương Thị Phương', CAST(N'1998-08-11' AS Date), N'Bắc Giang', N'Nữ', N'SH04      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [Diachi], [Gioitinh], [MalopSH]) VALUES (N'SV10      ', N'Đỗ Quốc Toản', CAST(N'1997-01-11' AS Date), N'Hà Nội', N'Nam', N'SH05      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [Diachi], [Gioitinh], [MalopSH]) VALUES (N'SV11      ', N'Nguyễn Thị Yến', CAST(N'1998-09-28' AS Date), N'Nghệ An', N'Nữ', N'SH05      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [Diachi], [Gioitinh], [MalopSH]) VALUES (N'SV12      ', N'Lê Thị Hồng Hạnh', CAST(N'1998-09-17' AS Date), N'Hà Nội', N'Nữ', N'SH06      ')

INSERT [dbo].[QuanliTH] ([MaSV], [Madetai], [NDthuchien], [ketqua], [vaitro]) VALUES (N'SV01      ', N'DT01      ', N'A', N'hoàn thành', N'trưởng nhóm')
INSERT [dbo].[QuanliTH] ([MaSV], [Madetai], [NDthuchien], [ketqua], [vaitro]) VALUES (N'SV02      ', N'DT01      ', N'B', N'hoàn thành', N'thành viên')
INSERT [dbo].[QuanliTH] ([MaSV], [Madetai], [NDthuchien], [ketqua], [vaitro]) VALUES (N'SV03      ', N'DT01      ', N'C', N'chưa hoàn thành', N'thành viên')
INSERT [dbo].[QuanliTH] ([MaSV], [Madetai], [NDthuchien], [ketqua], [vaitro]) VALUES (N'SV04      ', N'DT02      ', N'Q', N'chưa hoàn thành', N'thành viên')
INSERT [dbo].[QuanliTH] ([MaSV], [Madetai], [NDthuchien], [ketqua], [vaitro]) VALUES (N'SV05      ', N'DT02      ', N'W', N'hoàn thành', N'trưởng nhóm')
INSERT [dbo].[QuanliTH] ([MaSV], [Madetai], [NDthuchien], [ketqua], [vaitro]) VALUES (N'SV06      ', N'DT02      ', N'E', N'hoàn thành', N'thành viên')
INSERT [dbo].[QuanliTH] ([MaSV], [Madetai], [NDthuchien], [ketqua], [vaitro]) VALUES (N'SV07      ', N'DT03      ', N'Z', N'hoàn thành', N'trưởng nhóm')
INSERT [dbo].[QuanliTH] ([MaSV], [Madetai], [NDthuchien], [ketqua], [vaitro]) VALUES (N'SV08      ', N'DT03      ', N'X', N'hoàn thành', N'thành viên')
INSERT [dbo].[QuanliTH] ([MaSV], [Madetai], [NDthuchien], [ketqua], [vaitro]) VALUES (N'SV09      ', N'DT03      ', N'T', N'hoàn thành', N'thành viên')
INSERT [dbo].[QuanliTH] ([MaSV], [Madetai], [NDthuchien], [ketqua], [vaitro]) VALUES (N'SV10      ', N'DT04      ', N'G', N'chưa hoàn thành', N'trưởng nhóm')
INSERT [dbo].[QuanliTH] ([MaSV], [Madetai], [NDthuchien], [ketqua], [vaitro]) VALUES (N'SV11      ', N'DT04      ', N'H', N'chưa hoàn thành', N'thành viên')
INSERT [dbo].[QuanliTH] ([MaSV], [Madetai], [NDthuchien], [ketqua], [vaitro]) VALUES (N'SV12      ', N'DT04      ', N'I', N'chưa hoàn thành', N'thành viên')

INSERT [dbo].[TienDoTH] ([MaTD], [ketquaTD], [Madetai]) VALUES (N'TD01      ', N'8/10', N'DT01      ')
INSERT [dbo].[TienDoTH] ([MaTD], [ketquaTD], [Madetai]) VALUES (N'TD02      ', N'7/10', N'DT02      ')
INSERT [dbo].[TienDoTH] ([MaTD], [ketquaTD], [Madetai]) VALUES (N'TD03      ', N'9/10', N'DT03      ')
INSERT [dbo].[TienDoTH] ([MaTD], [ketquaTD], [Madetai]) VALUES (N'TD04      ', N'4/10', N'DT04      ')


--tạo các proc
create proc [dbo].[suasv] @hoten nvarchar(200),@ngaysinh date,@lopsh nvarchar(200), @diachi nvarchar(100),@tendt nvarchar(100),@noidung nvarchar(200),@vaitro nvarchar(200),@ketqua nvarchar(50)
as
begin
update dbo.SinhVien set Diachi=@diachi,NgaySinh=@ngaysinh,MalopSH=(select MalopSH from dbo.LopSH where Tenlopsh=@lopsh) where MaSV in (select MaSV from dbo.SinhVien where TenSV=@hoten)
update dbo.QuanliTH set Madetai = (select Madetai from dbo.DetaiNCKH where tendetai=@tendt),vaitro=@vaitro,NDthuchien=@noidung,ketqua=@ketqua where MaSV in (select MaSV from dbo.SinhVien where TenSV=@hoten)
end
go
create proc [dbo].[danhsachdetai]
as
select dt.stt,dt.Madetai N'Mã đề tài',dt.tendetai N'Tên đề tài',dt.noidung N'Nội dung',dt.ngaybd N'Ngày bắt đầu',dt.ngaykt N'Ngày kết thúc',gv.TenGV N'Giáo viên',cn.tenCN N'Chuyên ngành' from dbo.DetaiNCKH dt left join dbo.GiaoVien gv on dt.MaGV=gv.MaGV left join dbo.ChuyenNganh cn on dt.MaCN=cn.MaCN
go
create proc [dbo].[DanhSachGV]
as
select gv.STT,gv.MaGV,gv.TenGV N'Họ và tên',bm.tenbomon,dt.tendetai N'Đề tài',gv.gioitinhGV N'Giới tính',gv.ngaysinhgv N'Ngày sinh',gv.luong N'Lương'
from dbo.GiaoVien gv join dbo.BoMon bm on gv.Mabomon=bm.Mabomon left join dbo.DetaiNCKH dt on dt.MaGV=gv.MaGV
go
create proc [dbo].[DanhsachSV]
as
select sv.STT ,sv.MaSV,sv.TenSV N'Họ và tên',sv.NgaySinh N'Ngày sinh',sv.Gioitinh N'Giới tính',sv.Diachi N'Địa chỉ',lp.Tenlopsh N'Lớp SH',dt.tendetai N'Tên đề tài',ql.ketqua N'kết quả'
from dbo.SinhVien sv left join dbo.LopSH lp on sv.MalopSH=lp.MalopSH 
left join dbo.DetaiNCKH dt on dt.Madetai in (select ql.Madetai from dbo.QuanliTH ql where sv.MaSV=ql.MaSV)
left join dbo.QuanliTH ql on sv.MaSV=ql.MaSV
go
create proc [dbo].[suadetai] @tendt nvarchar(200),@noidung nvarchar(200),@ngaybd date,@ngaykt date,@giaovien nvarchar(200),@chuyennganh nvarchar(200)
as
begin
update dbo.DetaiNCKH set noidung=@noidung,ngaybd=@ngaybd,ngaykt=@ngaykt,
MaGV=(select MaGV from dbo.GiaoVien where TenGV=@giaovien),
MaCN=(select MaCN from dbo.ChuyenNganh where tenCN=@chuyennganh)
where tendetai=@tendt
end
go
create proc [dbo].[Suagiaovien] @hoten nvarchar(200),@ngaysinh date,@bommon nvarchar(200),@luong int
as
update dbo.GiaoVien set ngaysinhgv=@ngaysinh,luong=@luong,Mabomon=(select Mabomon from dbo.BoMon where tenbomon=@bommon) where TenGV=@hoten
go
create proc [dbo].[timkiemdetai] @ten nvarchar(200)
as
select dt.stt,dt.Madetai N'Mã đề tài',dt.tendetai N'Tên đề tài',dt.noidung N'Nội dung',dt.ngaybd N'Ngày bắt đầu',dt.ngaykt N'Ngày kết thúc',gv.TenGV N'Giáo viên',cn.tenCN N'Chuyên ngành' 
from dbo.DetaiNCKH dt  join dbo.GiaoVien gv on dt.MaGV=gv.MaGV and dt.tendetai like @ten join dbo.ChuyenNganh cn on dt.MaCN=cn.MaCN
go
create proc [dbo].[TimkiemGV] @tengv nvarchar(200)
as
select gv.STT,gv.MaGV,gv.TenGV N'Họ và tên',bm.tenbomon,dt.tendetai N'Đề tài',gv.gioitinhGV N'Giới tính',gv.ngaysinhgv N'Ngày sinh',gv.luong N'Lương'
from dbo.GiaoVien gv join dbo.BoMon bm on gv.Mabomon=bm.Mabomon and gv.TenGV like  @tengv left join dbo.DetaiNCKH dt on dt.MaGV=gv.MaGV
go
create proc [dbo].[TimkiemSV] @tensv nvarchar(200)
as
select sv.STT ,sv.MaSV,sv.TenSV N'Họ và tên',sv.NgaySinh N'Ngày sinh',sv.Gioitinh N'Giới tính',sv.Diachi N'Địa chỉ',lp.Tenlopsh N'Lớp SH',dt.tendetai N'Tên đề tài'
from dbo.SinhVien sv left join dbo.LopSH lp on sv.MalopSH=lp.MalopSH and sv.TenSV like @tensv
left join dbo.DetaiNCKH dt on dt.Madetai in (select ql.Madetai from dbo.QuanliTH ql where sv.MaSV=ql.MaSV)
go
create proc [dbo].[xoadetai] @tendt nvarchar(200)
as
begin
delete dbo.QuanliTH where Madetai in(select Madetai from dbo.DetaiNCKH where tendetai=@tendt)
delete dbo.TienDoTH where Madetai in(select Madetai from dbo.DetaiNCKH where tendetai=@tendt)
delete dbo.DetaiNCKH where tendetai=@tendt
end
go
create proc [dbo].[xoagiaovien] @ma char(10)
as
begin
update dbo.DetaiNCKH set MaGV=null where MaGV=@ma
delete dbo.GiaoVien where MaGV=@ma 
end
go
create proc [dbo].[XoaSV1] @hoten nvarchar(200)
as
begin
delete dbo.QuanliTH where MaSV in(select MaSV from dbo.SinhVien where TenSV=@hoten)
delete dbo.SinhVien where TenSV=@hoten
end
go



--tạo function
create function [dbo].[kiemtramadt](@ma char(10))
returns bit
as
begin
declare @a as bit
if(@ma not in( select Madetai from dbo.DetaiNCKH))
 set @a=0
 else
 set @a=1
 return @a
end
go
ALTER function [dbo].[kiemtraMGV](@ma char(10))
returns bit
as
begin
declare @a as bit
if(@ma not in(select MaGV from dbo.GiaoVien))
set @a=0
else set @a=1
return @a
end
go
create function [dbo].[kiemtraMSV](@ma char(10))
returns bit
as
begin
declare @a as bit
if(@ma not in (select MaSV from dbo.SinhVien))
set @a=0
else
set @a=1
return @a
end


















