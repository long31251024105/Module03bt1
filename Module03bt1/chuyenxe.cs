using System;

public abstract class ChuyenXe
{
    protected string maSoChuyen;
    protected string hoTenTaiXe;
    protected string soXe;
    protected double doanhThu;

    public ChuyenXe(string maSoChuyen, string hoTenTaiXe,
                    string soXe, double doanhThu)
    {
        this.maSoChuyen = maSoChuyen;
        this.hoTenTaiXe = hoTenTaiXe;
        this.soXe = soXe;
        this.doanhThu = doanhThu;
    }

    public double DoanhThu
    {
        get { return doanhThu; }
    }

    public abstract void XuatThongTin();
}