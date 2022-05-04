<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("等线", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(332, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 453)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "测试输出"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.Font = New System.Drawing.Font("宋体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(6, 24)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(513, 423)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(41, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(226, 47)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "查看当前网络设置(&S)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("等线", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "欢迎使用校园网测试工具" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "请选择测速节点，开始测试。"
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox1.Font = New System.Drawing.Font("等线", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBox1.Items.AddRange(New Object() {"校内 - 校园网接入认证系统", "校内 - 统一身份认证平台", "校内 - 教务网", "华北 - 北京", "华东 - 上海", "华南 - 广州", "西南 - 成都", "自定义节点"})
        Me.ComboBox1.Location = New System.Drawing.Point(41, 89)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(226, 26)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.Text = "请选择测试节点"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.Location = New System.Drawing.Point(41, 420)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(226, 47)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "清除日志并退出(&E)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(895, 520)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(887, 491)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "测速工具"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.AllowDrop = True
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("等线", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(41, 139)
        Me.TextBox2.MaxLength = 64
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(226, 25)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = "在此输入自定义测试节点"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(41, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(226, 47)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "开始测试(&T)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(887, 491)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "自助排障"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("等线", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(37, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(437, 26)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "注意：请在网络维护人员指导下使用！"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(606, 674)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 56)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button7.Location = New System.Drawing.Point(725, 603)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(99, 63)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "运行"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label12.Location = New System.Drawing.Point(38, 674)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(190, 21)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "正在运行，请稍后。"
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.Location = New System.Drawing.Point(38, 603)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(486, 63)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "重设代理设置" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- 部分代理或加速器类软件可能会导致无法正常联网，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- 使用本工具以将代理设置恢复到初始状态。"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button8.Location = New System.Drawing.Point(725, 477)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(99, 63)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "运行"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label14.Location = New System.Drawing.Point(38, 548)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(190, 21)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "正在运行，请稍后。"
        Me.Label14.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.Location = New System.Drawing.Point(38, 477)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(526, 63)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "初始化网络环境" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- 用于解决由于软件冲突、病毒原因造成的参数错误问题。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- 运行完毕后需要重启电脑。"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button6.Location = New System.Drawing.Point(725, 353)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 63)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "运行"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label10.Location = New System.Drawing.Point(38, 424)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(190, 21)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "正在运行，请稍后。"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(38, 353)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(418, 63)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "清除 DNS 缓存" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- 本地计算机存储的 DNS 缓存可能过时失效，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- 此问题会导致部分网站无法正常访问。"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button5.Location = New System.Drawing.Point(725, 227)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 63)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "运行"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label7.Location = New System.Drawing.Point(38, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "正在运行，请稍后。"
        Me.Label7.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(482, 63)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "重置 IP 及 DNS 设置" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- 用于系统无法正常获取 IP 地址时使用，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- 此操作会将本机重置为自动获取 IP 地址以及 DNS。"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label8.Location = New System.Drawing.Point(38, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 21)
        Me.Label8.TabIndex = 4
        Me.Label8.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label6.Location = New System.Drawing.Point(38, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 21)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "正在运行，请稍后。"
        Me.Label6.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(466, 63)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "刷新 IP 地址" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- 用于在已连接但无法正常从打开认证网页的情况，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- 运行完成后请重新登录校园网。"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button4.Location = New System.Drawing.Point(725, 101)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 63)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "运行"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.LinkLabel1)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(887, 491)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "关于本程序"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("等线", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LinkLabel1.LinkArea = New System.Windows.Forms.LinkArea(8, 13)
        Me.LinkLabel1.Location = New System.Drawing.Point(52, 377)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(296, 59)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Code by Михаил Молин" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copyright © 2022"
        Me.LinkLabel1.UseCompatibleTextRendering = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("等线", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.Location = New System.Drawing.Point(47, 425)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 26)
        Me.Label17.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("等线", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(478, 130)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "本工具可用于测试网络连通性和延迟，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "同时提供几个简单的网络故障排除功能。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "默认日志输出文件夹为 C:\Network_Testing" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "请在网络维护人员指" & _
    "导下使用。"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("等线", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(305, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 36)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Ver 1.0.2.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("等线", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 36)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "校园网测试工具"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 548)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "校园网测试工具"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Private WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label17 As System.Windows.Forms.Label

End Class
