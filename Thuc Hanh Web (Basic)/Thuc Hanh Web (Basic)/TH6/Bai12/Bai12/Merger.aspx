<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Merger.aspx.cs" Inherits="Bai12.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<frameset rows="75%,25%">
        <frameset cols="25%,75%">
            <frame name="left" src="User.aspx" />
            <frame name="right" src="MssengList.aspx" />
        </frameset>
        <frameset cols="100%">
            <frame name="bottom" src="SendMessen.html" />
        </frameset>
    </frameset>
<body></body>
</html>
