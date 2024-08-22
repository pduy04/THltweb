<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bai10.aspx.cs" Inherits="Bai10.bai10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bai 10</title>
    <script> 
            function checkVali() {
                var noidung = document.getElementById("txtNoidung");
                if (noidung.value === "") {
                    alert("Hãy nhập đủ nội dung");
                    return false;
                } else return true;
            }
        
    </script>
</head>
<body>
    <form id="form1" runat="server" method="post" enctype="multipart/form-data" onsubmit="return checkVali()">
        <div>
             <textarea id="txtNoidung" cols="20" name="noidung" rows="2"></textarea>
        </div>
        <p>
            <asp:FileUpload ID="txtFile" runat="server" />
        </p>
    <p>
        <input id="Submit" type="submit" value="Submit" /></p>
    </form>
    <div>
        <%  Response.Write("Nội Dung: " + Request.Form.Get("noidung")); %>
    </div>
</body>
</html>
