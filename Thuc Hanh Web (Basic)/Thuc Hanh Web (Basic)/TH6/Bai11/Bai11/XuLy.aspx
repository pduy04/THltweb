<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XuLy.aspx.cs" Inherits="Bai11.XuLy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/StyleSheet1.css" rel="stylesheet" />
    <title>Danh Sach</title>
</head>
<body>
    <form id="form1" runat="server">
         <div class="table-tt">
        <table>
            <tr>
                <th>STT</th>
                <th>Họ tên</th>
                <th>Ngày sinh</th>
            </tr>
            <asp:Literal ID="ltTable" runat="server"></asp:Literal>
        </table>
        <button><a href="htmlForm.html">Thêm</a></button>
    </div>
    </form>
</body>
</html>
