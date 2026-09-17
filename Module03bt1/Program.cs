using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo danh sách chuyến xe
        List<ChuyenXe> danhSach = new List<ChuyenXe>();

        // Tạo 2 chuyến xe nội thành
        ChuyenXeNoiThanh xeNoiThanh1 = new ChuyenXeNoiThanh(
            "NT01",
            "Nguyen Van An",
            "51A-12345",
            10,
            120,
            1500000
        );

        ChuyenXeNoiThanh xeNoiThanh2 = new ChuyenXeNoiThanh(
            "NT02",
            "Tran Van Binh",
            "51B-23456",
            15,
            180,
            2000000
        );

        // Tạo 2 chuyến xe ngoại thành
        ChuyenXeNgoaiThanh xeNgoaiThanh1 = new ChuyenXeNgoaiThanh(
            "NTG01",
            "Le Van Cuong",
            "51C-34567",
            "Vung Tau",
            2,
            3500000
        );

        ChuyenXeNgoaiThanh xeNgoaiThanh2 = new ChuyenXeNgoaiThanh(
            "NTG02",
            "Pham Van Dung",
            "51D-45678",
            "Da Lat",
            4,
            5000000
        );

        // Thêm vào danh sách
        danhSach.Add(xeNoiThanh1);
        danhSach.Add(xeNoiThanh2);
        danhSach.Add(xeNgoaiThanh1);
        danhSach.Add(xeNgoaiThanh2);

        // =========================
        // Xuất danh sách chuyến xe
        // =========================

        Console.WriteLine("===== DANH SÁCH CHUYẾN XE =====");
        Console.WriteLine();

        foreach (ChuyenXe xe in danhSach)
        {
            xe.XuatThongTin();
        }

        // =========================
        // Tổng doanh thu
        // =========================

        double tongDoanhThu = 0;

        foreach (ChuyenXe xe in danhSach)
        {
            tongDoanhThu += xe.DoanhThu;
        }

        Console.WriteLine(
            $"Tổng doanh thu tất cả chuyến xe: {tongDoanhThu:N0} VNĐ");

        // =========================
        // Doanh thu nội thành
        // =========================

        double doanhThuNoiThanh = 0;

        foreach (ChuyenXe xe in danhSach)
        {
            if (xe is ChuyenXeNoiThanh)
            {
                doanhThuNoiThanh += xe.DoanhThu;
            }
        }

        Console.WriteLine(
            $"Tổng doanh thu xe nội thành: {doanhThuNoiThanh:N0} VNĐ");

        // =========================
        // Doanh thu ngoại thành
        // =========================

        double doanhThuNgoaiThanh = 0;

        foreach (ChuyenXe xe in danhSach)
        {
            if (xe is ChuyenXeNgoaiThanh)
            {
                doanhThuNgoaiThanh += xe.DoanhThu;
            }
        }

        Console.WriteLine(
            $"Tổng doanh thu xe ngoại thành: {doanhThuNgoaiThanh:N0} VNĐ");

        Console.ReadKey();
    }
}