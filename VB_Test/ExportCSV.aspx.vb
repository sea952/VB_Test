Imports System.IO

Public Class ExportCSV
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Me.IsPostBack Then
            'Gridview資料
            Dim arrCustID As String() = New String(3) {}
            arrCustID(0) = "C01"
            arrCustID(1) = "C02"
            arrCustID(2) = "C03"
            arrCustID(3) = "C04"
            GridView1.DataSource = arrCustID
            GridView1.DataBind()
        End If


    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        Dim CustNameArrayList As New ArrayList
        With CustNameArrayList
            .Add(New String() {0, "C01", "A"})
            .Add(New String() {1, "C02", "B"})
            .Add(New String() {2, "C03", "C"})
            .Add(New String() {3, "C04", "D"})
        End With

        Dim selectedCust As String = ""
        Dim selectedCustList As New ArrayList

        'Checkbox取得的Data再去Database中取得資料
        '這邊用Array代替,再改寫成從Database取得資料
        For i As Integer = 0 To (GridView1.Rows.Count - 1)
            Dim myCheckbox As CheckBox = GridView1.Rows(i).FindControl("CheckBox1")
            Dim custName As Label = GridView1.Rows(i).FindControl("custId")

            If myCheckbox.Checked = True Then
                If String.IsNullOrEmpty(selectedCust) = True Then
                    selectedCust = selectedCust
                Else
                    selectedCust = selectedCust & ", " & custName.Text
                End If

                For Each cust In CustNameArrayList
                    If cust(1) = custName.Text Then
                        selectedCustList.Add(New String() {cust(1), cust(2)})
                    End If
                Next
            End If
        Next

        '確認Checkbox的資料用
        Label1.Text = selectedCust

        '匯出為csv檔

        'CSVファイルに書き込むときに使うEncoding
        Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")

        '書き込むファイルを開く
        Dim sr As New System.IO.StreamWriter("C:\CSV\Test.csv", False, enc)

        'レコードを書き込む
        For k As Integer = 0 To (selectedCustList.Count - 1)
            'フィールドを書き込む
            sr.Write(selectedCustList(k)(0).ToString())
            'カンマを書き込む(依個人喜好調整)
            sr.Write(","c)
            'フィールドを書き込む
            sr.Write(selectedCustList(k)(1).ToString())
            'カンマを書き込む(依個人喜好調整)
            sr.Write(","c)
            '改行する
            sr.Write(vbCrLf)
        Next

        '閉じる
        sr.Close()

    End Sub
End Class