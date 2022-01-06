Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItem.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Select()
        TextBox1.Text = ""

    End Sub

    Private Sub DeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteItem.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex = 0)
    End Sub
End Class
