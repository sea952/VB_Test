<%@ Page Title="Export to CSV" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="ExportCSV.aspx.vb" Inherits="VB_Test.ExportCSV" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Test Export to CSV
    </h2>
    <p>
        Click to Export CSV File
    </p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField>
                <EditItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Cust ID">
                <ItemTemplate >
                    <asp:Label ID = "custId" runat = "server" text = '<%# Container.DataItem %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Export" />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
