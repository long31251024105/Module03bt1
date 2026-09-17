using System;

public class ChuyenXeNgoaiThanh : ChuyenXe
{
    private string noiDen;
    private int soNgayDiDuoc;

    public ChuyenXeNgoaiThanh(
        string maSoChuyen,
        string hoTenTaiXe,
        string soXe,
        string noiDen,
        int soNgayDiDuoc,
        double doanhThu)
        : base(maSoChuyen, hoTenTaiXe, soXe, doanhThu)
    {
        this.noiDen = noiDen;
        this.soNgayDiDuoc = soNgayDiDuoc;
    }

    public override void XuatThongTin()
    {
        Console.WriteLine("Chuyến xe ngoại thành");
        Console.WriteLine($"Mã số chuyến: {maSoChuyen}");
        Console.WriteLine($"Họ tên tài xế: {hoTenTaiXe}");
        Console.WriteLine($"Số xe: {soXe}");
        Console.WriteLine($"Nơi đến: {noiDen}");
        Console.WriteLine($"Số ngày đi được: {soNgayDiDuoc}");
        Console.WriteLine($"Doanh thu: {doanhThu:N0} VNĐ");
        Console.WriteLine("----------------------------");
    }
}