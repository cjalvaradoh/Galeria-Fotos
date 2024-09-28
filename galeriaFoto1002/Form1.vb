Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog() 'presentar dialogo al usuario'
        openFileDialog.Multiselect = True 'habilita cargar multiples fotos'
        openFileDialog.Filter = "Archivos de imagen |*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            'pueden ser varias imagenes, por ello se ejecuta un ciclo'
            For Each archivo As String In openFileDialog.FileNames
                Dim miniatura As New PictureBox() 'Se crea nueva caja de imagen'
                miniatura.SizeMode = PictureBoxSizeMode.Zoom
                miniatura.Image = Image.FromFile(archivo)
                miniatura.Width = 100
                miniatura.Height = 100

                FlowLayoutPanel1.Controls.Add(miniatura)
            Next
        End If
    End Sub
End Class
