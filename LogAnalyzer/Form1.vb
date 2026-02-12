Imports System.IO

Public Class Form1
    ' Variabel untuk menghitung warnings
    Dim countCritical As Integer = 0
    Dim countWarning As Integer = 0
    Dim countInfo As Integer = 0

    ' KRITERIA: PROCEDURE 
    Private Sub AnalisisData(baris As String)
        If baris.ToUpper.Contains("FAILED") Or baris.ToUpper.Contains("DENIED") Then
            lstResult.Items.Add("[CRITICAL] " & baris)
            countCritical += 1
        ElseIf baris.ToUpper.Contains("WARNING") Then
            lstResult.Items.Add("[WARNING] " & baris)
            countWarning += 1
        Else
            lstResult.Items.Add("[INFO] " & baris)
            countInfo += 1
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim bukaFile As New OpenFileDialog
        bukaFile.Filter = "Log Files (*.log;*.txt)|*.log;*.txt"

        If bukaFile.ShowDialog() = DialogResult.OK Then
            ' Reset variabel sebelum mulai (Penting agar hitungan tidak menumpuk)
            txtFilePath.Text = bukaFile.FileName
            lstResult.Items.Clear()
            countCritical = 0
            countWarning = 0
            countInfo = 0

            Try
                'KRITERIA: MEMBACA FILE
                Dim isiLog As String() = File.ReadAllLines(txtFilePath.Text)

                ' KRITERIA: PERULANGAN 
                For Each barisTeks As String In isiLog
                    If barisTeks.Trim <> "" Then
                        ' Memanggil Procedure
                        AnalisisData(barisTeks)
                    End If
                Next

                ' KRITERIA: MENAMPILKAN HASIL DETAIL 
                Dim totalBaris As Integer = isiLog.Length

                ' Menampilkan status yang sangat detail 
                lblStat.Text = String.Format("Selesai! Total: {0} | Crit: {1} | Warn: {2} | Info: {3}",
                                             totalBaris, countCritical, countWarning, countInfo)

                ' Beri warna merah jika ada ancaman kritis, hijau jika aman
                If countCritical > 0 Then
                    lblStat.ForeColor = Color.Red
                Else
                    lblStat.ForeColor = Color.DarkGreen
                End If

            Catch ex As Exception
                MessageBox.Show("Terjadi error saat membaca file: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtFilePath.Clear()
        lstResult.Items.Clear()
        countCritical = 0
        countWarning = 0
        countInfo = 0
        lblStat.Text = "Status: Siap."
        lblStat.ForeColor = Color.Black
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' 1. Validasi: Cek apakah ada data untuk disimpan?
        If lstResult.Items.Count = 0 Then
            MessageBox.Show("Tidak ada data untuk disimpan.", "Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Siapkan Dialog Penyimpanan
        Dim saveDlg As New SaveFileDialog()
        saveDlg.Filter = "Text File (*.txt)|*.txt"
        saveDlg.Title = "Simpan Laporan Log"
        ' Nama file otomatis: Log_TahunBulanHari_JamMenitDetik.txt
        saveDlg.FileName = "Log_" & DateTime.Now.ToString("yyyyMMdd_HHmmss")

        ' 3. Proses Menyimpan
        If saveDlg.ShowDialog() = DialogResult.OK Then
            Try
                ' Membuka file untuk ditulis (StreamWriter)
                Using writer As New StreamWriter(saveDlg.FileName)
                    writer.WriteLine("==========================================")
                    writer.WriteLine("LAPORAN ANALISIS KEAMANAN (SECURITY LOG)")
                    writer.WriteLine("==========================================")
                    writer.WriteLine("Tanggal Scan : " & DateTime.Now.ToString())
                    writer.WriteLine("Lokasi File  : " & txtFilePath.Text)
                    writer.WriteLine("Ringkasan    : " & lblStat.Text)
                    writer.WriteLine("==========================================")
                    writer.WriteLine("")

                    For Each item As String In lstResult.Items
                        writer.WriteLine(item)
                    Next
                End Using

                MessageBox.Show("Laporan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class