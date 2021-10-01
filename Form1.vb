Public Class FormArray

    Private Sub FormArray_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Arr(3, 1) As String
        Arr(0, 0) = "NIS"
        Arr(0, 1) = "Nama"
        Arr(1, 0) = "Jenis kelamin"
        Arr(1, 1) = "Jurusan"
        Arr(2, 0) = "Laki-Laki"
        Arr(2, 1) = "Perempuan"
        Arr(3, 0) = "Rekayasa Perangkat Lunak"
        Arr(3, 1) = "Teknik Komputer Jaringan"
        ListView1.GridLines = True
        ListView1.View = View.Details

        For baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(Arr(baris, kolom), 120)
            Next kolom
        Next baris

        For baris = 2 To 2
            For kolom = 0 To 1
                cbKelamin.Items.Add(Arr(baris, kolom))
            Next kolom
        Next baris

        For baris = 3 To 3
            For kolom = 0 To 1
                cbProdi.Items.Add(Arr(baris, kolom))
            Next kolom
        Next baris

    End Sub
    Private Sub btProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProses.Click
        Dim Arr(3) As String
        Arr(0) = txNim.Text
        Arr(1) = txNama.Text
        Arr(2) = cbKelamin.Text
        Arr(3) = cbProdi.Text

        Dim listitem = New ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        listitem.SubItems.Add(Arr(3))
        txNim.Text = txNim.Text + 1
        txNama.Clear()
        cbKelamin.Text = ""
        cbProdi.Text = ""
        txNama.Focus()
    End Sub

    Private Sub cbProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProdi.SelectedIndexChanged

    End Sub
End Class
