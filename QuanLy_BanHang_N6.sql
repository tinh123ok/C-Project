USE [demosql]
GO
/****** Object:  StoredProcedure [dbo].[layLH_NCC]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[layLH_NCC](@NCC varchar(20))
as
	begin
	select *
	from LoaiHang
	where MaNCC = @NCC
end
GO
/****** Object:  StoredProcedure [dbo].[sp_chotdon]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_chotdon](@maDH int)
as
	begin
	update DonHang
	set ChotDon = 1
	where MaDH = @maDH
end
GO
/****** Object:  StoredProcedure [dbo].[sp_dsLoaihang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_dsLoaihang]
as 
	begin
	select * from LoaiHang
end
GO
/****** Object:  StoredProcedure [dbo].[sp_dsmathang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_dsmathang]
as 
	begin
	select * from MatHang
end
GO
/****** Object:  StoredProcedure [dbo].[sp_dsVoucher]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_dsVoucher]
as 
	begin
	select * from Voucher
end
GO
/****** Object:  StoredProcedure [dbo].[sp_laydsCTDH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_laydsCTDH]
as
	begin
	select*
	from ChiTietDonHang
end
GO
/****** Object:  StoredProcedure [dbo].[sp_laydsDH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_laydsDH](@chotdon int)
as
	begin
	select*,dbo.tongdagiam(MaDH) as'TongTien'
	from DonHang
	where ChotDon = @chotdon
end
GO
/****** Object:  StoredProcedure [dbo].[sp_laydsKH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_laydsKH]
as
	begin
	select*
	from KhachHang
end
GO
/****** Object:  StoredProcedure [dbo].[sp_laydsMH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_laydsMH]
as
	begin
	select * from MatHang
end
GO
/****** Object:  StoredProcedure [dbo].[sp_laydsMH_user]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_laydsMH_user]
as
	begin
	select H.MaHang,H.TenHang,H.giabanra,H.soluong,L.TenLH,N.TenCTy,H.ngayhethang
	from MatHang H,LoaiHang L, NhaCungcap N
	where L.TenLH in (select LoaiHang.TenLH from LoaiHang where MaLH = H.MaLH) 
	and N.TenCTy in (select TenCTy from NhaCungcap where MaNCC like H.MaNCC)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LaydsNhaCungCap]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LaydsNhaCungCap]
as 
	begin
	select * from NhaCungcap
end
GO
/****** Object:  StoredProcedure [dbo].[sp_laydsvoucher]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_laydsvoucher]
as
	begin
	select maVoucher,tenVoucher
	from Voucher
end

GO
/****** Object:  StoredProcedure [dbo].[sp_laydsvoucher_dieukien]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_laydsvoucher_dieukien](@dk int)
as
	begin
	select maVoucher,tenVoucher
	from Voucher
	where dieukien < @dk or dieukien = @dk
end
GO
/****** Object:  StoredProcedure [dbo].[sp_layhang_DH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_layhang_DH](@maDH int)
as
	begin
	select *
	from ChiTietDonHang
	where MaDH = @maDH
end
GO
/****** Object:  StoredProcedure [dbo].[sp_laymaDH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_laymaDH](@mavach varchar(20))
as
	begin
	select MaDH
	from DonHang
	where MaVach = @mavach
end
GO
/****** Object:  StoredProcedure [dbo].[sp_laymaKH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_laymaKH](@ten nvarchar(150),@sdt varchar(20),@diachi nvarchar(150))
as 
	begin
	select MaKH
	from KhachHang
	where TenKH like @ten and Sdt like @sdt and DC = @diachi
end
GO
/****** Object:  StoredProcedure [dbo].[sp_laysp_cosl]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_laysp_cosl](@maMH varchar(20),@sl int)
as
	begin
	select H.MaHang,H.TenHang,@sl as 'soluong',H.giabanra, L.TenLH ,N.TenCTy, H.ngayhethang
	from MatHang H,LoaiHang L,NhaCungcap N
	where H.MaHang like @maMH 
	and L.TenLH in (select TenLH from LoaiHang where MaLH = H.MaLH)
	and N.TenCTy in (select TenCTy from NhaCungcap where MaNCC = H.MaNCC)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_laysp_cosl_tomtat]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_laysp_cosl_tomtat](@maMH varchar(20),@sl int)
as
	begin
	select H.MaHang,H.TenHang,@sl as 'soluong',H.giabanra
	from MatHang H
	where H.MaHang like @maMH
end
GO
/****** Object:  StoredProcedure [dbo].[sp_laysp_DH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_laysp_DH](@maDH int)
as
	begin
	select CT.MaHang,H.TenHang,H.giabanra,CT.Soluong,L.TenLH,N.TenCTy,H.ngayhethang
	from ChiTietDonHang CT,MatHang H,LoaiHang L, NhaCungcap N
	where CT.MaDH = @maDH
	and H.TenHang in (select TenHang from MatHang where MaHang = CT.MaHang)
	and L.TenLH in (select LoaiHang.TenLH from LoaiHang where MaLH = H.MaLH)
	and N.TenCTy in (select TenCTy from NhaCungcap where MaNCC like H.MaNCC)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaCTDH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaCTDH](@MaDH int,
	@MaHang varchar(20),
	@Soluong int)
as
	begin
	update ChiTietDonHang
	set  Soluong = @Soluong
	where MaDH = @MaDH and MaHang = @MaHang
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaDH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaDH](@MaDH int,
	@MaKH int,
	@NgayDatHang datetime)
as
	begin
	set dateformat DMY
	update DonHang
	set MaKH = @MaKH
	where MaDH = @MaDH
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaKH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaKH](@MaKH int,
	@TenKH nvarchar(150),
	@DC nvarchar(150),
	@Sdt varchar(20),
	@Email varchar(50))
as
	begin
	set dateformat DMY
	update KhachHang
	set TenKH=@TenKH, DC=@DC, Sdt=@Sdt, Email=@Email
	where MaKH = @MaKH
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Sualoaihang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Sualoaihang](@MaLH  varchar(20) ,@MaNCC varchar(20),@TenLH nvarchar(150))
as 
	begin
	set dateformat DMY
	update LoaiHang
	set MaLH = @MaLH,MaNCC = @MaNCC ,TenLH = @TenLH
	where MaLH = @MaLH
end
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaMathang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaMathang](@MaHang varchar(20),
	@TenHang nvarchar(150),
	@MaNCC varchar(20),
	@MaLH varchar(20),
	@soluong int ,
	@ngayhethang date,
	@gianhapvao int,
	@giabanra int)
as 
	begin
	update MatHang
	set TenHang = @TenHang ,MaNCC = @MaNCC,MaLH = @MaLH,soluong = @soluong,ngayhethang = @ngayhethang,gianhapvao = @gianhapvao, giabanra = @giabanra
	where  MaHang = @MaHang
end
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaNhacungcap]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaNhacungcap](@mancc varchar(20), @tenncc nvarchar(150),@diachi nvarchar(150),@email varchar(50),@sodienthoai varchar(20))
as 
	begin
	update NhaCungcap
	set MaNCC = @mancc,TenCTy = @tenncc ,DC = @diachi,Email = @email,Sdt = @sodienthoai
	where MaNCC = @mancc
end

GO
/****** Object:  StoredProcedure [dbo].[sp_SuaVoucher]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaVoucher](@maVoucher int,
	@tenVoucher nvarchar(150) ,
	@giatri int,
	@dieukien int )
as 
	begin
	set dateformat DMY
	update Voucher
	set tenVoucher = @tenVoucher,giatri = @giatri ,dieukien = @dieukien
	where maVoucher = @maVoucher
end
GO
/****** Object:  StoredProcedure [dbo].[sp_timkiemdh]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_timkiemdh](@maDH int,@chotdon int)
as	
	begin
	select*,dbo.tongdagiam(MaDH) as'TongTien'
	from DonHang
	where MaDH = @maDH and ChotDon = @chotdon
end
GO
/****** Object:  StoredProcedure [dbo].[sp_timkiemKhachhang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_timkiemKhachhang](@TenKH nvarchar(150))
as 
	begin
	select*
	from KhachHang
	WHERE TenKH LIKE @TenKH or DC like @TenKH or Sdt like @TenKH 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_timkiemLoaihang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_timkiemLoaihang](@TenLH nvarchar(150))
as 
	begin
	select*
	from LoaiHang
	WHERE TenLH like @TenLH 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_timkiemMathang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_timkiemMathang](@TenHang nvarchar(150))
as 
	begin
	select*
	from MatHang
	WHERE TenHang LIKE @TenHang 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_timkiemMavoucher]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_timkiemMavoucher](@tenVoucher nvarchar(150))
as 
	begin
	select*
	from Voucher
	WHERE tenVoucher like @tenVoucher 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_timkiemncc]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_timkiemncc](@tenncc nvarchar(150))
as 
	begin
	select*
	from NhaCungcap
	WHERE TenCTy like @tenncc or MaNCC = @tenncc or DC like @tenncc
end
GO
/****** Object:  StoredProcedure [dbo].[sp_timkiemsp]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_timkiemsp](@key nvarchar(150))
as
	begin
	select H.MaHang,H.TenHang,H.giabanra,L.TenLH,N.TenCTy,H.ngayhethang
	from MatHang H,LoaiHang L, NhaCungcap N
	where L.TenLH in (select LoaiHang.TenLH from LoaiHang where MaLH = H.MaLH)
	and N.TenCTy in (select TenCTy from NhaCungcap where MaNCC like H.MaNCC)
	and (H.MaHang like @key or H.TenHang like @key or N.TenCTy like @key)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_timmavach]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_timmavach](@mavach varchar(20))
as
	begin
	select MaVach
	from DonHang
	where MaVach = @mavach
end
GO
/****** Object:  StoredProcedure [dbo].[sp_themCTDH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themCTDH](@MaDH int,
	@MaHang varchar(20),
	@Soluong int)
as
	begin
	insert into ChiTietDonHang(MaDH,MaHang,Soluong)
	values(@MaDH,@MaHang,@Soluong)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_themDH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themDH](@MaKH int,
	@mavach varchar(20) ,
	@mavoucher int )
as
	begin
	set dateformat DMY
	insert into DonHang(MaKH , MaVach , maVoucher)
	values(@MaKH,@mavach,@mavoucher)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_themKH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themKH](
	@TenKH nvarchar(150),
	@DC nvarchar(150),
	@Sdt varchar(20),
	@Email varchar(50))
as
	begin
	set dateformat DMY
	insert into KhachHang(TenKH,DC,Sdt,Email)
	values(@TenKH,@DC,@Sdt,@Email)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemLoaihang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemLoaihang] (@MaLH varchar(20) ,@MaNCC varchar(20),@TenLH nvarchar(150))
as 
	begin
	set dateformat DMY
	insert into LoaiHang(MaLH,MaNCC,TenLH)
	values(@MaLH,@MaNCC,@TenLH)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemMathang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemMathang] (@MaHang varchar(20),
	@TenHang nvarchar(150),
	@MaNCC varchar(20),
	@MaLH varchar(20),
	@soluong int ,
	@ngayhethang date,
	@gianhapvao int,
	@giabanra int
	)
as 
	begin
	set dateformat DMY
	insert into MatHang(MaHang,TenHang,MaNCC,MaLH,soluong,ngayhethang,gianhapvao,giabanra)
	values(@MaHang,@TenHang,@MaNCC,@MaLH,@soluong,@ngayhethang,@gianhapvao,@giabanra)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNCC]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemNCC](@mancc varchar(20), @tenncc nvarchar(150),@diachi nvarchar(150),@email varchar(50),@sodienthoai varchar(20))
as 
	begin
	insert into NhaCungcap(MaNCC,TenCTy,DC,Email,Sdt)
	values(@mancc,@tenncc,@diachi,@email,@sodienthoai)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemVoucher]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemVoucher] (
	@tenVoucher nvarchar(150) ,
	@giatri int,
	@dieukien int )
as 
	begin
	set dateformat DMY
	insert into Voucher(tenVoucher,giatri,dieukien)
	values(@tenVoucher,@giatri,@dieukien)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaCTDH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xoaCTDH](@maDH int,@MaHang varchar(20))
as
	begin
	delete 
	from ChiTietDonHang
	where MaDH = @maDH and MaHang = @MaHang
end
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaDH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xoaDH](@maDH int)
as
	begin
	delete 
	from ChiTietDonHang
	where MaDH =@maDH
	delete 
	from DonHang
	where MaDH =@maDH
end
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaKH]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xoaKH](@maKH int)
as
	begin
	delete 
	from KhachHang
	where MaKH =@maKH
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaLoaihang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaLoaihang](@malh varchar(20))
as
	begin
    delete 
	from LoaiHang
	where MaLH =@malh
end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaMathang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaMathang](@MaHang varchar(20))
as
	begin
	delete 
	from MatHang
	where MaHang =@MaHang
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Xoancc]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Xoancc](@mancc varchar(20))
as
	begin
	delete 
	from NhaCungcap
	where MaNCC =@mancc
end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaVoucher]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaVoucher](@maVoucher int)
as
	begin
    delete 
	from Voucher
	where maVoucher =@maVoucher
end
GO
/****** Object:  StoredProcedure [dbo].[suasl_hang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suasl_hang](@mahang varchar(20),@sl int)
as
	begin
	update MatHang 
	set soluong = @sl
	where MaHang = @mahang
end
GO
/****** Object:  UserDefinedFunction [dbo].[e]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[e](@maDH int)
returns int
as
begin
	declare @tong int
	set @tong = dbo.tongtien_hang_banra(@maDH)-dbo.laygiatrivoucher(dbo.laymavoucher(@maDH))
	return @tong
end

GO
/****** Object:  UserDefinedFunction [dbo].[laygiahang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[laygiahang](@mahang varchar(20))
returns int
as 
begin
	DECLARE @gia_hang int
	select @gia_hang = MatHang.giabanra
	from MatHang
	where MaHang = @mahang
	return @gia_hang
end
GO
/****** Object:  UserDefinedFunction [dbo].[laygiahang_nhapvao]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[laygiahang_nhapvao](@mahang varchar(20))
returns int
as 
begin
	DECLARE @gia_hang int
	select @gia_hang = MatHang.gianhapvao
	from MatHang
	where MaHang = @mahang
	return @gia_hang
end
GO
/****** Object:  UserDefinedFunction [dbo].[laygiatrivoucher]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[laygiatrivoucher](@mavoucher int)
returns int
as
begin
	DECLARE @giatri int
	select @giatri = Voucher.giatri
	from Voucher
	where Voucher.maVoucher = @mavoucher
	return @giatri
end
GO
/****** Object:  UserDefinedFunction [dbo].[laymavoucher]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[laymavoucher](@maDH int)
returns int
as begin
	declare @mavc int
	select @mavc = maVoucher
	from DonHang
	where MaDH = @maDH
	return @mavc
end
GO
/****** Object:  UserDefinedFunction [dbo].[SL_hang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[SL_hang]
(
    @maDH int
)
RETURNS int
AS 
BEGIN
	DECLARE @dem int
	select @dem = count(MaDH)
	from ChiTietDonHang
	where MaDH = @maDH
	
    RETURN @dem
END;

GO
/****** Object:  UserDefinedFunction [dbo].[tongdagiam]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[tongdagiam](@maDH int)
returns int
as
begin
	declare @tong int
	set @tong = dbo.tongtien_hang_banra(@maDH)-dbo.laygiatrivoucher(dbo.laymavoucher(@maDH))
	return @tong
end
GO
/****** Object:  UserDefinedFunction [dbo].[tongtien_hang_banra]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[tongtien_hang_banra]
(
    @maDH int
)
RETURNS int
AS 
BEGIN
	DECLARE @tong int
	if dbo.SL_hang(@maDH) > 0
	select @tong = sum(dbo.laygiahang(CT.MaHang) *CT.Soluong)
	from ChiTietDonHang CT
	where CT.MaDH = @maDH 
	ELSE
	set @tong = 0;
    RETURN @tong
END;
GO
/****** Object:  UserDefinedFunction [dbo].[tongtien_hang_nhapvao]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[tongtien_hang_nhapvao]
(
    @maDH int
)
RETURNS int
AS 
BEGIN
	DECLARE @tong int
	if dbo.SL_hang(@maDH) > 0
	select @tong = sum(dbo.laygiahang_nhapvao(CT.MaHang) *CT.Soluong)
	from ChiTietDonHang CT
	where CT.MaDH = @maDH;
	ELSE
	set @tong = 0;
	
    RETURN @tong
END;

GO
/****** Object:  Table [dbo].[Admin]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin](
	[taikhoan] [varchar](50) NOT NULL,
	[matkhau] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaDH] [int] NOT NULL,
	[MaHang] [varchar](20) NOT NULL,
	[Soluong] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDH] [int] IDENTITY(1,1) NOT NULL,
	[MaVach] [varchar](20) NULL,
	[MaKH] [int] NOT NULL,
	[NgayDatHang] [date] NULL DEFAULT (getdate()),
	[maVoucher] [int] NULL DEFAULT ((1)),
	[ChotDon] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](150) NOT NULL,
	[DC] [nvarchar](150) NOT NULL,
	[Sdt] [varchar](20) NOT NULL,
	[Email] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiHang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiHang](
	[MaLH] [varchar](20) NOT NULL,
	[MaNCC] [varchar](20) NOT NULL,
	[TenLH] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MatHang](
	[MaHang] [varchar](20) NOT NULL,
	[TenHang] [nvarchar](150) NOT NULL,
	[MaNCC] [varchar](20) NOT NULL,
	[MaLH] [varchar](20) NOT NULL,
	[soluong] [int] NOT NULL,
	[ngayhethang] [date] NULL,
	[gianhapvao] [int] NOT NULL,
	[giabanra] [int] NOT NULL,
	[ngaynhap] [date] NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungcap]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungcap](
	[MaNCC] [varchar](20) NOT NULL,
	[TenCTy] [nvarchar](150) NOT NULL,
	[DC] [nvarchar](150) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Sdt] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Voucher]    Script Date: 12/12/2021 11:43:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voucher](
	[maVoucher] [int] IDENTITY(1,1) NOT NULL,
	[tenVoucher] [nvarchar](150) NOT NULL,
	[giatri] [int] NULL DEFAULT ((1)),
	[dieukien] [int] NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[maVoucher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Admin] ([taikhoan], [matkhau]) VALUES (N'admin', N'1')
INSERT [dbo].[ChiTietDonHang] ([MaDH], [MaHang], [Soluong]) VALUES (4, N'ACPG', 1)
INSERT [dbo].[ChiTietDonHang] ([MaDH], [MaHang], [Soluong]) VALUES (6, N'DNCSC', 1)
INSERT [dbo].[ChiTietDonHang] ([MaDH], [MaHang], [Soluong]) VALUES (6, N'DASSS', 1)
INSERT [dbo].[ChiTietDonHang] ([MaDH], [MaHang], [Soluong]) VALUES (6, N'DTVSF', 1)
INSERT [dbo].[ChiTietDonHang] ([MaDH], [MaHang], [Soluong]) VALUES (6, N'HHG2', 1)
INSERT [dbo].[ChiTietDonHang] ([MaDH], [MaHang], [Soluong]) VALUES (6, N'DAASF', 1)
INSERT [dbo].[ChiTietDonHang] ([MaDH], [MaHang], [Soluong]) VALUES (6, N'BNASS', 1)
SET IDENTITY_INSERT [dbo].[DonHang] ON 

INSERT [dbo].[DonHang] ([MaDH], [MaVach], [MaKH], [NgayDatHang], [maVoucher], [ChotDon]) VALUES (1, N'21378', 1, CAST(N'2021-12-11' AS Date), 1, 0)
INSERT [dbo].[DonHang] ([MaDH], [MaVach], [MaKH], [NgayDatHang], [maVoucher], [ChotDon]) VALUES (3, N'213728', 1, CAST(N'2021-12-11' AS Date), 1, 0)
INSERT [dbo].[DonHang] ([MaDH], [MaVach], [MaKH], [NgayDatHang], [maVoucher], [ChotDon]) VALUES (4, N'33429', 4, CAST(N'2021-12-12' AS Date), 1, 1)
INSERT [dbo].[DonHang] ([MaDH], [MaVach], [MaKH], [NgayDatHang], [maVoucher], [ChotDon]) VALUES (6, N'34754', 6, CAST(N'2021-12-12' AS Date), 2, 1)
SET IDENTITY_INSERT [dbo].[DonHang] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DC], [Sdt], [Email]) VALUES (1, N'Tính', N'Phú Giáo', N'0322625111', N'tinh123ok@gmail.com')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DC], [Sdt], [Email]) VALUES (2, N'Lan', N'Phú Giáo', N'0361271281', N'tinh123ok@gmail.com')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DC], [Sdt], [Email]) VALUES (3, N'Tung', N'Phú Giáo', N'0362511165', N'tinh123ok@gmail.com')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DC], [Sdt], [Email]) VALUES (4, N'tinh la', N'dsadwdwd', N'0738219987', N'qwdwk@kdwqw')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DC], [Sdt], [Email]) VALUES (6, N'la tinh', N'dsadasd', N'0123456789', N'tinhhdqwdo@')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'ACMI1', N'ACECOOK', N'Mì tôm Acecook')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'ACP', N'ACECOOK', N'Phở Acecook')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'ACHT', N'ACECOOK', N'Hủ tiếu Acecook')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'BBCB', N'BIBICA', N'Kẹo Bibica')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'BBCK', N'BIBICA', N'Bánh Bibica')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'BDAI', N'KDO', N'Bánh dài')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'Beer', N'PSC', N'Bia')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'BKN', N'KDO', N'Bánh không nhân')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'BQ', N'KDO', N'Bánh Quy')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'BSN', N'KDO', N'Bánh Snack')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'BSW', N'KDO', N'Bánh Sandwich')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'CSHN', N'CHINSU', N'Hạt nêm Chinsu')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'CSNM', N'CHINSU', N'Nước mắm Chinsu')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'CSNT', N'CHINSU', N'Nước tương Chinsu')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'DAAS', N'ASIAFOOD', N'Dầu ăn Asiafood')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'GVASS', N'ASIAFOOD', N'Gia vị Asiafood')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'KSD', N'SENSODYNE', N'Kem đánh răng Sensodyne')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'NMASS', N'ASIAFOOD', N'Nước mắm Asiafood')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'NSD', N'SENSODYNE', N'Nước vệ sinh răng miệng Sensodyne')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'NTT', N'PSC', N'Nước tăng lực')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'NGK', N'PSC', N'Nước giải khát')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'NGKKD', N'PSC', N'Nước giải khát không đường')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'R1', N'PSC', N'Rượu')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'VNMCD', N'VNM', N'Sữa tiệt trùng Vinamilk có đường')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'VNMKD', N'VNM', N'Sữa tiệt trùng Vinamilk không đường')
INSERT [dbo].[LoaiHang] ([MaLH], [MaNCC], [TenLH]) VALUES (N'VNMSDK1', N'VNM', N'Sữa đặc VinamilkK')
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'ACPG', N'Phở bò Hảo hảo', N'ACECOOK', N'ACP', 2300, CAST(N'2022-02-05' AS Date), 5500, 7700, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'BNASS', N'Hạt nêm Asiafood', N'ASIAFOOD', N'GVASS', 1999, CAST(N'2023-01-04' AS Date), 17000, 19000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'CCC', N'Cocacola - Chanh', N'PSC', N'NGK', 300, CAST(N'2022-12-02' AS Date), 8000, 12000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'DAASF', N'Dầu đậu nành Asiafood', N'ASIAFOOD', N'DAAS', 99, CAST(N'2023-01-07' AS Date), 47000, 49000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'DASSS', N'Đường cát Asiafood', N'ASIAFOOD', N'GVASS', 999, CAST(N'2023-01-12' AS Date), 17000, 22000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'DCHSF', N'Dầu Cá hồi Asiafood', N'ASIAFOOD', N'DAAS', 200, CAST(N'2023-01-04' AS Date), 57000, 69000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'DDVSRM', N'Dung dịch vệ sinh răng miệng Sensodyne', N'SENSODYNE', N'NSD', 100, CAST(N'2023-01-07' AS Date), 37000, 42000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'DNCS', N'Nước tương đậu nành Chinsu', N'CHINSU', N'CSNT', 3000, CAST(N'2022-08-02' AS Date), 11000, 13700, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'DNCSC', N'Nước tương đậu nành Chinsu - Đặc biệt', N'CHINSU', N'CSNT', 1199, CAST(N'2022-09-02' AS Date), 18000, 24000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'DNCSCC', N'Nước tương đậu nành Chinsu - Cay', N'CHINSU', N'CSNT', 1500, CAST(N'2022-08-23' AS Date), 14500, 17000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'DOLSF', N'Dầu Olive Asiafood', N'ASIAFOOD', N'DAAS', 200, CAST(N'2023-03-08' AS Date), 57000, 65000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'DTVSF', N'Dầu thực vật Asiafood', N'ASIAFOOD', N'DAAS', 99, CAST(N'2023-01-13' AS Date), 47000, 49000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'HH1', N'Mì tôm chua cay Hảo hảo', N'ACECOOK', N'ACMI1', 3000, CAST(N'2022-02-08' AS Date), 2500, 3700, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'HHG2', N'Mì Gà sợi phở Hảo hảo', N'ACECOOK', N'ACMI1', 1199, CAST(N'2022-02-09' AS Date), 2600, 4200, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'HHMC', N'Hủ tiếu nam vang Hảo hảo', N'ACECOOK', N'ACHT', 2300, CAST(N'2022-03-08' AS Date), 4500, 7700, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'HHSP', N'Hủ tiếu nam vang Hảo hảo đặc biệt', N'ACECOOK', N'ACHT', 1300, CAST(N'2022-12-04' AS Date), 6500, 9700, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'HNASS', N'Bột ngọt Asiafood', N'ASIAFOOD', N'GVASS', 2000, CAST(N'2023-03-08' AS Date), 17000, 20000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'HNC', N'Hạt nêm chay Chinsu - Đặc biệt', N'CHINSU', N'CSHN', 2200, CAST(N'2022-09-02' AS Date), 19000, 25000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'HNT', N'Hạt nêm Chinsu', N'CHINSU', N'CSHN', 3000, CAST(N'2022-08-02' AS Date), 13000, 16700, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'KDR', N'Kem đánh răng Sensodyne', N'SENSODYNE', N'KSD', 100, CAST(N'2023-03-07' AS Date), 27500, 35000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'KDRD', N'Kem đánh răng Sensodyne vị dâu', N'SENSODYNE', N'KSD', 100, CAST(N'2023-01-07' AS Date), 37000, 42000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'KDRM', N'Kem đánh răng Sensodyne - Đặc biệt', N'SENSODYNE', N'KSD', 200, CAST(N'2023-04-07' AS Date), 45000, 60000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'MASS', N'Muối tinh khiết Asiafood', N'ASIAFOOD', N'GVASS', 1000, CAST(N'2023-01-07' AS Date), 4700, 5900, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'NMAA1', N'Nước mắm Asiafood', N'ASIAFOOD', N'NMASS', 200, CAST(N'2023-08-08' AS Date), 27000, 35000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'NMCSDB', N'Nước mắm Chinsu - Đặc biệt', N'CHINSU', N'CSNT', 1280, CAST(N'2022-09-02' AS Date), 28000, 34000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'NMCST', N'Nước Mắm Chinsu', N'CHINSU', N'CSNM', 1230, CAST(N'2022-08-02' AS Date), 21000, 26700, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'NMHHAA1', N'Nước mắm hảo hạn Asiafood', N'ASIAFOOD', N'NMASS', 100, CAST(N'2023-01-01' AS Date), 37000, 49000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'PS', N'Pepsi', N'PSC', N'NGK', 500, CAST(N'2022-12-02' AS Date), 7000, 13000, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaNCC], [MaLH], [soluong], [ngayhethang], [gianhapvao], [giabanra], [ngaynhap]) VALUES (N'PSC', N'Pepsi - Chanh không calo', N'PSC', N'NGK', 350, CAST(N'2022-12-02' AS Date), 7500, 12500, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'ACECOOK', N'Công Ty Cổ Phần ACECOOK Việt Nam', N'KCN Tân Bình ,P.Tân Phú,TP.HCM', N'info@acecook.com.vn', N'02838154064')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'ASIAFOOD', N'Công Ty Thực  Phẩm Á Châu', N'9/2 DT734 An Phú,Thuận An,Bình Dương', N'info@asiafoods.com', N'02743712888')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'BIBICA', N'Công Ty CP Bibica', N'43 Lý Thường Kiệt, P.8 Q.Tân Bình, TP.HCM', N'bibica@bibica.com', N'02839717920')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'CHINSU', N'Công Ty TNHH Power Media', N'40 Trần Văn Quang,P.10,Q.Tân Bình,TP.HCM', N'chinsu.com@gmail.com', N'0284467294')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'HAIHACO', N'Công Ty Bánh Kẹo Hải Hà', N'25 Trương Đ?nh , Qu?n Hai Bà Trưng ,TP.Hà N?i', N'info@haihaco.com.vn', N'0901771911')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'HUUNGHI', N'Công Ty CP Thực Phẩm Hữu Nghị', N'122 Định Công,P.Định Công,Q.Hoàng Mai,TP.Hà Nội', N'media@huunghi.com.vn', N'02436649451')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'IDP', N'Công Ty Cổ Phần Sữa Quốc Tế', N'217 Nguyễn Văn Thủ ,Đa Kao,Quận 1 , TP.HCM', N'info@idp.vn', N'02433811949')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'KDC', N'Tập Đoàn Kido', N'138 Hai Bà Trưng ,Đa Kao,Quận 1 , TP.HCM', N'info@kdc.vn', N'2838270468')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'KDO', N'Công ty Cổ phần Bánh Việt Nam KINH ĐÔ', N'Thành phố Hồ Chí Minh', N'Kinhdo@gmail.com', N'04677723555')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'LIFEBUOY', N'Công Ty TNHH Quốc Tế Unilever Việt Nam', N'156 Nguyễn Lương Bằng,P.Tân Phú,Q.7,TP.HCM', N'lifebouy@mail.com', N'0838236651')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'MD', N'Công Ty Nhag Minh Đức', N'Tân Chánh Hiệp,Hóc Môn, TP.HCM', N'nhangmd@gmail.com', N'0918328188')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'NESTLE', N'Công Ty TNHH Nestle Việt Nam', N'138 Hai Bà Trưng ,Đa Kao,Quận 1 , TP.HCM', N'nestle@vn.nestle.com', N'0283823863')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'PSC', N'Công ty Cổ phần Nước Giải khát Việt Nam PEPSICO', N'Bình Dương', N'Pepsico01@gmail.com', N'02832434995')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'SENSODYNE', N'Công ty TNHH DKSH Việt Nam', N' KCN VN-Singapore,TX Thuận An,Bình Dương', N' Antoanthuoc@gsk.com', N'02838248744')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'THP', N'Tập Đoàn Nước Giải Khát Tân Hiệp Phát', N'219 Đại Lộ Bình Dương,TP.Thuận An,Bình Dương', N'info@thp.vn', N'0898760066')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'TRUNGNGUYENLEGEND', N'Công Ty CP Cà Phê Trung Nguyên', N'82-84 Bùi Thị Xuân, P. Bến Nghé, Q. 1,TP.HCM', N'of@trungnguyen.com', N'02839251845')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'VINAMILK', N'Cửa Hàng Sản Phẩm Vinamilk', N'38,Nguyễn Oanh,P7,Q.GV,TP.HCM', N'vinamilk@gmail.com', N'02839890800')
INSERT [dbo].[NhaCungcap] ([MaNCC], [TenCTy], [DC], [Email], [Sdt]) VALUES (N'VNM', N'Công ty Cổ phần Sữa Việt Nam Vinamilk', N'Thành phố Hồ Chí Minh', N'Vinamilk@gmail.com', N'02854155555')
SET IDENTITY_INSERT [dbo].[Voucher] ON 

INSERT [dbo].[Voucher] ([maVoucher], [tenVoucher], [giatri], [dieukien]) VALUES (1, N'DEFAULT', 0, 0)
INSERT [dbo].[Voucher] ([maVoucher], [tenVoucher], [giatri], [dieukien]) VALUES (2, N'giảm 50k', 50000, 5)
INSERT [dbo].[Voucher] ([maVoucher], [tenVoucher], [giatri], [dieukien]) VALUES (3, N'giảm 100k', 100000, 10)
SET IDENTITY_INSERT [dbo].[Voucher] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__DonHang__8BBF4A1C42CF1664]    Script Date: 12/12/2021 11:43:24 CH ******/
ALTER TABLE [dbo].[DonHang] ADD UNIQUE NONCLUSTERED 
(
	[MaVach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [fk_DH_CTDH] FOREIGN KEY([MaDH])
REFERENCES [dbo].[DonHang] ([MaDH])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [fk_DH_CTDH]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [fk_Hang_CTDH] FOREIGN KEY([MaHang])
REFERENCES [dbo].[MatHang] ([MaHang])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [fk_Hang_CTDH]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [fk_KH_DH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [fk_KH_DH]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [fk_VC_DH] FOREIGN KEY([maVoucher])
REFERENCES [dbo].[Voucher] ([maVoucher])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [fk_VC_DH]
GO
ALTER TABLE [dbo].[LoaiHang]  WITH CHECK ADD  CONSTRAINT [fk_LH_NCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungcap] ([MaNCC])
GO
ALTER TABLE [dbo].[LoaiHang] CHECK CONSTRAINT [fk_LH_NCC]
GO
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD  CONSTRAINT [fk_MH_LH] FOREIGN KEY([MaLH])
REFERENCES [dbo].[LoaiHang] ([MaLH])
GO
ALTER TABLE [dbo].[MatHang] CHECK CONSTRAINT [fk_MH_LH]
GO
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD  CONSTRAINT [fk_MH_NCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungcap] ([MaNCC])
GO
ALTER TABLE [dbo].[MatHang] CHECK CONSTRAINT [fk_MH_NCC]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [sdt1] CHECK  ((len([Sdt])>=(10) AND len([Sdt])<=(11)))
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [sdt1]
GO
ALTER TABLE [dbo].[NhaCungcap]  WITH CHECK ADD  CONSTRAINT [sdt2] CHECK  ((len([Sdt])>=(10) AND len([Sdt])<=(11)))
GO
ALTER TABLE [dbo].[NhaCungcap] CHECK CONSTRAINT [sdt2]
GO
