 
Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Data
Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0
        Dim sql As String = Nothing
        Dim connetionString As String = "Data Source=.;Initial Catalog=pubs;User ID=sa;Password=*****"
        sql = "select * from stores"
        Dim connection As New SqlConnection(connetionString)
        connection.Open()
        Dim command As New SqlCommand(sql, connection)
        adapter.SelectCommand = command
        adapter.Fill(ds)
        adapter.Dispose()
        command.Dispose()
        connection.Close()
        GridView1.DataSource = ds.Tables(0)
        GridView1.DataBind()
    End Sub
    Protected Sub btntoExcel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Response.ClearContent()
        Response.AddHeader("content-disposition", "attachment; filename=gvtoexcel.xls")
        Response.ContentType = "application/excel"
        Dim sw As New System.IO.StringWriter()
        Dim htw As New HtmlTextWriter(sw)
        GridView1.RenderControl(htw)
        Response.Write(sw.ToString())
        Response.[End]()
    End Sub
    Public Overrides Sub VerifyRenderingInServerForm(ByVal control As Control)
        'Tell the compiler that the control is rendered
        'explicitly by overriding the VerifyRenderingInServerForm event.
    End Sub
  End Class
