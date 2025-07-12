Imports System.Diagnostics
Imports System.IO

Module CHOPYKEUN
    Sub Main()
        Console.Title = "CHOPYKEUN - Created by Nova"
        Console.ForegroundColor = ConsoleColor.Green

        ' ASCII LOGO tanpa karakter spesial
        Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════════")
        Console.WriteLine("                                                                                       ")
        Console.WriteLine("   ██████╗██╗  ██╗ ██████╗ ██████╗ ██╗   ██╗██╗  ██╗███████╗██╗   ██╗███████╗███╗   ██╗")
        Console.WriteLine("  ██╔════╝██║  ██║██╔═══██╗██╔══██╗╚██╗ ██╔╝██║ ██╔╝██╔════╝██║   ██║██╔════╝████╗  ██║")
        Console.WriteLine("  ██║     ███████║██║   ██║██████╔╝ ╚████╔╝ █████╔╝ █████╗  ██║   ██║█████╗  ██╔██╗ ██║")
        Console.WriteLine("  ██║     ██╔══██║██║   ██║██╔═══╝   ╚██╔╝  ██╔═██╗ ██╔══╝  ╚██╗ ██╔╝██╔══╝  ██║╚██╗██║")
        Console.WriteLine("  ╚██████╗██║  ██║╚██████╔╝██║        ██║   ██║  ██╗███████╗ ╚████╔╝ ███████╗██║ ╚████║")
        Console.WriteLine("   ╚═════╝╚═╝  ╚═╝ ╚═════╝ ╚═╝        ╚═╝   ╚═╝  ╚═╝╚══════╝  ╚═══╝  ╚══════╝╚═╝  ╚═══╝")
        Console.WriteLine("                        CHOPYKEUN Terminal File Copy Tool - CREATED BY NOVA")
        Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════════")
        Console.WriteLine()

        ' Input source folder
        Console.Write("📂 Source Folder (ex: D:\Data): ")
        Dim source As String = Console.ReadLine().Trim()

        If Not Directory.Exists(source) Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("❌ Source folder tidak ditemukan!")
            Exit Sub
        End If

        ' Input destination folder
        Console.Write("💾 Destination Folder (ex: F:\Backup): ")
        Dim destination As String = Console.ReadLine().Trim()

        If Not Directory.Exists(destination) Then
            Directory.CreateDirectory(destination)
            Console.WriteLine("📁 Destination folder dibuat otomatis.")
        End If

        ' Pilih mode copy
        Console.WriteLine()
        Console.WriteLine("🔘 Copy Mode:")
        Console.WriteLine("1. Copy seluruh isi folder")
        Console.WriteLine("2. Copy hanya file/folder tertentu")
        Console.Write("Pilih [1 / 2]: ")
        Dim opsi As String = Console.ReadLine().Trim()

        Dim argTambahan As String = ""

        If opsi = "1" Then
            argTambahan = "/E"
        ElseIf opsi = "2" Then
            Console.Write("📝 Masukkan nama file/folder (dipisah spasi): ")
            argTambahan = Console.ReadLine().Trim()
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("❌ Pilihan tidak valid.")
            Exit Sub
        End If

        ' Buat log file
        Dim logFile As String = Path.Combine(destination, "log_shadowcopy_" & Now.ToString("yyyyMMdd_HHmmss") & ".txt")

        ' 👇 FIXED: robocopyCmd sudah dideklarasikan
        Dim robocopyCmd As String = "robocopy """ & source & """ """ & destination & """ " & argTambahan & " /Z /ETA /R:3 /W:5 /TEE /LOG:""" & logFile & """"

        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("* Menjalankan SHADOW COPY ENGINE...")
        Console.WriteLine("══════════════════════════════════════════════════════════════════════════════")
        Console.ForegroundColor = ConsoleColor.Green

        ' Jalankan robocopy
        Dim proc As New Process()
        proc.StartInfo.FileName = "cmd.exe"
        proc.StartInfo.Arguments = "/c " & robocopyCmd
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.CreateNoWindow = True

        proc.Start()

        ' Tampilkan hasil real-time
        While Not proc.StandardOutput.EndOfStream
            Dim line = proc.StandardOutput.ReadLine()
            If line.Contains("ERROR") OrElse line.Contains("Access is denied") Then
                Console.ForegroundColor = ConsoleColor.Red
            Else
                Console.ForegroundColor = ConsoleColor.Green
            End If
            Console.WriteLine(line)
        End While

        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine()
        Console.WriteLine("✅ Selesai! Log disimpan di: " & logFile)
        Console.WriteLine("══════════════════════════════════════════════════════════════════════════════")
        Console.WriteLine()
        Console.Write("🔚 Tekan ENTER untuk keluar...")
        Console.ReadLine()
    End Sub
End Module
