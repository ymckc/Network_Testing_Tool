
Public Class Form1

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        '点击右上角关闭按钮时的操作
        Shell("cmd /c del /F /S /Q C:\Network_Testing")
        Shell("cmd /c rmdir C:\Network_Testing")
        If Button8.Text = ("完成") Or Button8.Enabled = False Then
            If MsgBox("已经重置了网络环境，需要重新启动才能应用更改。" + Chr(10) + "是否现在重新启动？", vbYesNo Or vbExclamation, "提示") = MsgBoxResult.Yes Then
                Shell("shutdown.exe /r /t 0")
            Else
                Me.Dispose()
            End If
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '执行当前设置检查操作
        TextBox1.Text = ("正在处理，请稍后")

        Dim Log As String
        My.Computer.FileSystem.CreateDirectory("C:\Network_Testing")
        Dim A As Process = Process.Start("C:\Windows\System32\cmd.exe", "/c ipconfig > C:\Network_Testing\Adapter_Config.log")
        A.WaitForExit()
        Log = My.Computer.FileSystem.ReadAllText("C:\Network_Testing\Adapter_Config.log", System.Text.Encoding.Default)
        TextBox1.Text = ("****** IP Config Information ******") + Chr(10) + Log + Chr(10) + ("****** END ******")

        '复制输出回显的内容到剪贴板，以下同类型语句同理
        My.Computer.Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '定义所需常量
        Dim PingLog_Login As String
        Dim PingLog_Custom As String
        Dim PingLog_CAS As String
        Dim PingLog_JW As String
        Dim PingLog_Beijing As String
        Dim PingLog_Shanghai As String
        Dim PingLog_Guangzhou As String
        Dim PingLog_Chengdu As String

        '临时窗口顶置
        Me.TopMost = True

        '在还未选择节点时进行提示
        If ComboBox1.Text = ("请选择测试节点") Then
            TextBox1.Text = ("请首先选择一个测试节点。")
        Else
            TextBox1.Text = ("正在测试，请不要关闭弹出的 CMD 窗口。")
        End If

        '校园网登录节点
        If ComboBox1.Text = ("校内 - 校园网接入认证系统") Then
            Dim p As Process = Process.Start("C:\Windows\System32\cmd.exe", "/c ping 222.192.254.21 -n 10 > C:\Network_Testing\ping_Login.log")
            p.WaitForExit()
            PingLog_Login = My.Computer.FileSystem.ReadAllText("C:\Network_Testing\ping_Login.log", System.Text.Encoding.Default)
            TextBox1.Text = ("****** Login Result ******") + Chr(10) + PingLog_Login + Chr(10) + ("****** END ******")
            My.Computer.Clipboard.SetText(TextBox1.Text)
        End If

        '校内 CAS 节点
        If ComboBox1.Text = ("校内 - 统一身份认证平台") Then
            Dim p As Process = Process.Start("C:\Windows\System32\cmd.exe", "/c ping 222.192.248.29 -n 10 > C:\Network_Testing\ping_CAS.log")
            p.WaitForExit()
            PingLog_CAS = My.Computer.FileSystem.ReadAllText("C:\Network_Testing\ping_CAS.log", System.Text.Encoding.Default)
            TextBox1.Text = ("****** CAS Result ******") + Chr(10) + PingLog_CAS + Chr(10) + ("****** END ******")
            My.Computer.Clipboard.SetText(TextBox1.Text)
        End If

        '校内教务网节点
        If ComboBox1.Text = ("校内 - 教务网") Then
            Dim p As Process = Process.Start("C:\Windows\System32\cmd.exe", "/c ping 222.192.251.32 -n 10 > C:\Network_Testing\ping_JW.log")
            p.WaitForExit()
            PingLog_JW = My.Computer.FileSystem.ReadAllText("C:\Network_Testing\ping_JW.log", System.Text.Encoding.Default)
            TextBox1.Text = ("****** JW Result ******") + Chr(10) + PingLog_JW + Chr(10) + ("****** END ******")
            My.Computer.Clipboard.SetText(TextBox1.Text)
        End If

        '北京节点
        If ComboBox1.Text = ("华北 - 北京") Then
            Dim p As Process = Process.Start("C:\Windows\System32\cmd.exe", "/c ping 140.249.68.149 -n 10 > C:\Network_Testing\ping_Beijing.log")
            p.WaitForExit()
            PingLog_Beijing = My.Computer.FileSystem.ReadAllText("C:\Network_Testing\ping_Beijing.log", System.Text.Encoding.Default)
            TextBox1.Text = ("****** Beijing Result ******") + Chr(10) + PingLog_Beijing + Chr(10) + ("****** END ******")
            My.Computer.Clipboard.SetText(TextBox1.Text)
        End If

        '上海节点
        If ComboBox1.Text = ("华东 - 上海") Then
            Dim p As Process = Process.Start("C:\Windows\System32\cmd.exe", "/c ping 58.217.230.58 -n 10 > C:\Network_Testing\ping_Shanghai.log")
            p.WaitForExit()
            PingLog_Shanghai = My.Computer.FileSystem.ReadAllText("C:\Network_Testing\ping_Shanghai.log", System.Text.Encoding.Default)
            TextBox1.Text = ("****** Shanghai Result ******") + Chr(10) + PingLog_Shanghai + Chr(10) + ("****** END ******")
            My.Computer.Clipboard.SetText(TextBox1.Text)
        End If

        '广州节点
        If ComboBox1.Text = ("华南 - 广州") Then
            Dim p As Process = Process.Start("C:\Windows\System32\cmd.exe", "/c ping 14.119.113.22 -n 10 > C:\Network_Testing\ping_Guangzhou.log")
            p.WaitForExit()
            PingLog_Guangzhou = My.Computer.FileSystem.ReadAllText("C:\Network_Testing\ping_Guangzhou.log", System.Text.Encoding.Default)
            TextBox1.Text = ("****** Guangzhou Result ******") + Chr(10) + PingLog_Guangzhou + Chr(10) + ("****** END ******")
            My.Computer.Clipboard.SetText(TextBox1.Text)
        End If

        '成都节点
        If ComboBox1.Text = ("西南 - 成都") Then
            Dim p As Process = Process.Start("C:\Windows\System32\cmd.exe", "/c ping 221.178.72.149 -n 10 > C:\Network_Testing\ping_Chengdu.log")
            p.WaitForExit()
            PingLog_Chengdu = My.Computer.FileSystem.ReadAllText("C:\Network_Testing\ping_Chengdu.log", System.Text.Encoding.Default)
            TextBox1.Text = ("****** Chengdu Result ******") + Chr(10) + PingLog_Chengdu + Chr(10) + ("****** END ******")
            My.Computer.Clipboard.SetText(TextBox1.Text)
        End If

        '自定义节点
        If ComboBox1.Text = ("自定义节点") Then
            If TextBox2.Text = ("在此输入自定义测试节点") Then
                TextBox1.Text = ("请首先输入自定义测试节点。")
            Else
                TextBox1.Text = ("正在测试，请不要关闭弹出的 CMD 窗口。")
                Dim p As Process = Process.Start("C:\Windows\System32\cmd.exe", "/c ping " + TextBox2.Text + " -n 10 > C:\Network_Testing\ping_Custom.log")
                p.WaitForExit()
                PingLog_Custom = My.Computer.FileSystem.ReadAllText("C:\Network_Testing\ping_Custom.log", System.Text.Encoding.Default)
                TextBox1.Text = ("****** Custom Result ******") + Chr(10) + PingLog_Custom + Chr(10) + ("****** END ******")
                My.Computer.Clipboard.SetText(TextBox1.Text)
            End If
        End If

        '解除窗口顶置
        Me.TopMost = False
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        '用于实现当下拉选择选中自定义时启用自定义节点输入框
        If ComboBox1.Text = ("自定义节点") Then
            TextBox2.Enabled = True
        Else
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '点击退出按钮时的操作
        Shell("cmd /c del /F /S /Q C:\Network_Testing")
        Shell("cmd /c rmdir C:\Network_Testing")
        If Button8.Text = ("完成") Then
            If MsgBox("已经重置了网络环境，需要重新启动才能应用更改。" + Chr(10) + "是否现在重新启动？", vbYesNo Or vbExclamation, "提示") = MsgBoxResult.Yes Then
                Shell("shutdown.exe /r /t 0")
            Else
                Me.Dispose()
            End If
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '刷新 IP 地址
        Label6.Visible = True
        Dim A As Process = Process.Start("C:\Windows\System32\ipconfig.exe", " /release")
        A.WaitForExit()
        Dim B As Process = Process.Start("C:\Windows\System32\ipconfig.exe", " /renew")
        B.WaitForExit()
        Label6.Visible = False
        Button4.Enabled = False
        Button4.Text = ("完成")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '重置 IP 设置
        Label7.Visible = True
        Dim A As Process = Process.Start("C:\Windows\System32\netsh.exe", "int ip reset")
        A.WaitForExit()
        Label7.Visible = False
        Button5.Enabled = False
        Button5.Text = ("完成")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '清除 DNS 缓存
        Label10.Visible = True
        Dim A As Process = Process.Start("C:\Windows\System32\ipconfig.exe", " /flushdns")
        A.WaitForExit()
        Label10.Visible = False
        Button6.Enabled = False
        Button6.Text = ("完成")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '重设网络环境
        Label14.Visible = True
        Dim A As Process = Process.Start("C:\Windows\System32\netsh.exe", " winsock reset")
        A.WaitForExit()
        Label14.Visible = False
        Button8.Enabled = False
        Button8.Text = ("完成")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '清除代理
        Label12.Visible = True
        Dim A As Process = Process.Start("C:\Windows\System32\netsh.exe", " winhttp reset proxy")
        A.WaitForExit()
        Label12.Visible = False
        Button7.Enabled = False
        Button7.Text = ("完成")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        '关于页打开邮件
        System.Diagnostics.Process.Start("http://mail.qq.com/cgi-bin/qm_share?t=qm_mailme&email=tM3Z19-X9NLbzNnV3dia19vZ")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        '程序启动时自动创建日志文件夹
        My.Computer.FileSystem.CreateDirectory("C:\Network_Testing")
    End Sub
End Class