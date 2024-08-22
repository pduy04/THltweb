<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Xuly.aspx.cs" Inherits="Bai9.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Assets/css/Bai9.css" rel="stylesheet" />
    <script src="Assets/js/TH4-Bai8.js"></script>
    <title>Bai 9</title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div class="nhap">
        <table>
            <tr>
                <td>Tên VXL</td>
                <td><input type="text" name="ten" id="ten"></td>
            </tr>
            <tr>
                <td>Hãng</td>
                <td><input type="text" name="hang" id="hang"></td>
                
            </tr>
            <tr>
                <td>Ngày ra mắt</td>
                <td><input type="date" name="ngay" id="ngay"></td>
            </tr>
            <tr>
                <td>Giá</td>
                <td><input type="number" name="gia" id="gia"></td>
            </tr>
            <tr>
                <td colspan="2">
                    <div class="btn">
                        <input type="submit" id="btnSub" value="Thêm" onclick="them()">
                        <input type="reset" value="Hủy" onclick="huy()">
                    </div>
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
