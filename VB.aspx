<%@ Page Language="VB" AutoEventWireup="false" CodeFile="VB.aspx.vb" Inherits="VB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="GridView1" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
        RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
        runat="server" AutoGenerateColumns="false" AllowPaging="true" OnPageIndexChanging="OnPageIndexChanging">
        <Columns>
            <asp:BoundField DataField="ContactName" HeaderText="Contact Name" ItemStyle-Width="150px" />
            <asp:BoundField DataField="City" HeaderText="City" ItemStyle-Width="100px" />
            <asp:BoundField DataField="Country" HeaderText="Country" ItemStyle-Width="100px" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="btnExport" runat="server" Text="Export To Excel" OnClick = "ExportToExcel" />
    </form>
</body>
</html>
