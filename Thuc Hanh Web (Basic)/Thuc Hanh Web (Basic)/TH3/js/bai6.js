function xem() {
    var ngay = new Date(document.getElementById('ngaysinh').value);
    if (ngay == null) {
        alert('Hãy nhập ngày tháng');
        document.getElementById('ngaysinh').focus();
    }
    var day = ngay.getDate();//Phương thức getDate() được dùng để lấy NGÀY của một đối tượng ngày tháng.
    var month = ngay.getMonth() + 1;// trả về từ 0 đến 11
    var cung = document.getElementById('cung');
    cung.value = xacdinhcung(day, month);
}
function xacdinhcung(day, month) {
    switch (month) {
        case 1:
            if (day <= 19) return "Ma Kết";
            else return "Bảo Bình";
        case 2:
            if (day <= 18) return "Bảo Bình";
            else return "Song Ngư";
        case 3:
            if (day <= 20) return "Song Ngư";
            else return "Bạch Dương";
        case 4:
            if (day <= 20) return "Bạch Dương";
            else return "Kim Ngưu";
        case 5:
            if (day <= 20) return "Kim Ngưu";
            else return "Song Tử";
        case 6:
            if (day <= 22) return "Song Tử";
            else return "Cự Giải";
        case 7:
            if (day <= 22) return "Cự Giải";
            else return "Sư Tử";
        case 8:
            if (day <= 22) return "Sư Tử";
            else return "Xử Nữ";
        case 9:
            if (day <= 22) return "Xử Nữ";
            else return "Thiên Bình";
        case 10:
            if (day <= 23) return "Thiên Bình";
            else return "Bọ Cạp";
        case 11:
            if (day <= 22) return "Bọ Cạp";
            else return "Nhân Mã";
        case 12:
            if (day <= 21) return "Nhân Mã";
            else return "Ma Kết";
        default:
            alert('Hãy nhập ngày tháng năm');
            document.getElementById('ngaysinh').focus();
            return "Chưa nhập dữ liệu";
    }
}
function xoa() {
    document.getElementById('ngaysinh').value = "";
    document.getElementById('cung').value = "";
}