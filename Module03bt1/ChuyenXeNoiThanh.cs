using System;

public class ChuyenXeNoiThanh : ChuyenXe
{
    private int soTuyen;
    private double soKmDiDuoc;

    public ChuyenXeNoiThanh(
        string maSoChuyen,
        string hoTenTaiXe,
        string soXe,
        int soTuyen,
        double soKmDiDuoc,
        double doanhThu)
        : base(maSoChuyen, hoTenTaiXe, soXe, doanhThu)
    {
        this.soTuyen = soTuyen;
        this.soKmDiDuoc = soKmDiDuoc;
    }

    public override void XuatThongTin()
    {
        Console.WriteLine("Chuyến xe nội thành");
        Console.WriteLine($"Mã số chuyến: {maSoChuyen}");
        Console.WriteLine($"Họ tên tài xế: {hoTenTaiXe}");
        Console.WriteLine($"Số xe: {soXe}");
        Console.WriteLine($"Số tuyến: {soTuyen}");
        Console.WriteLine($"Số km đi được: {soKmDiDuoc}");
        Console.WriteLine($"Doanh thu: {doanhThu:N0} VNĐ");
        Console.WriteLine("----------------------------");
    }
}