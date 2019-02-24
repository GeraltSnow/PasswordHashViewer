<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Button6 = New System.Windows.Forms.Button()
        Me.FileIB = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonGetUsers = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListViewUsers = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UserListViewContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyFirstHashMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopySecondHashMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelDatabaseVersion = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SQLPassword = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SQLLogin = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SQLDatabase = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SQLInstance = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SQLServer = New System.Windows.Forms.TextBox()
        Me.SQLUserList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SQLUserListViewContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SQLCopyFirstHashMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SQLCopySecondHashMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.UserListViewContextMenuStrip.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SQLUserListViewContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(640, 7)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 40)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Выбрать файл"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'FileIB
        '
        Me.FileIB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileIB.Location = New System.Drawing.Point(9, 25)
        Me.FileIB.Name = "FileIB"
        Me.FileIB.Size = New System.Drawing.Size(625, 20)
        Me.FileIB.TabIndex = 9
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "1C DB files|*.1cd"
        Me.OpenFileDialog.RestoreDirectory = True
        Me.OpenFileDialog.Title = "Выберите файл информационной базы 1С"
        '
        'ButtonGetUsers
        '
        Me.ButtonGetUsers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGetUsers.Location = New System.Drawing.Point(748, 7)
        Me.ButtonGetUsers.Name = "ButtonGetUsers"
        Me.ButtonGetUsers.Size = New System.Drawing.Size(102, 40)
        Me.ButtonGetUsers.TabIndex = 12
        Me.ButtonGetUsers.Text = "Получить список пользователей"
        Me.ButtonGetUsers.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(748, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 40)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Получить список пользователей"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(864, 396)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListViewUsers)
        Me.TabPage1.Controls.Add(Me.LabelDatabaseVersion)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.FileIB)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.ButtonGetUsers)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(856, 370)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Файловая база"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListViewUsers
        '
        Me.ListViewUsers.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListViewUsers.AllowDrop = True
        Me.ListViewUsers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListViewUsers.ContextMenuStrip = Me.UserListViewContextMenuStrip
        Me.ListViewUsers.FullRowSelect = True
        Me.ListViewUsers.HideSelection = False
        Me.ListViewUsers.LabelEdit = True
        Me.ListViewUsers.LabelWrap = False
        Me.ListViewUsers.Location = New System.Drawing.Point(8, 53)
        Me.ListViewUsers.MultiSelect = False
        Me.ListViewUsers.Name = "ListViewUsers"
        Me.ListViewUsers.Size = New System.Drawing.Size(841, 290)
        Me.ListViewUsers.TabIndex = 27
        Me.ListViewUsers.UseCompatibleStateImageBehavior = False
        Me.ListViewUsers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "GUID"
        Me.ColumnHeader3.Width = 216
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Имя пользователя"
        Me.ColumnHeader7.Width = 126
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Хэш пароля в нижнем регистре"
        Me.ColumnHeader8.Width = 195
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Хэш пароля в верхнем регистре"
        Me.ColumnHeader9.Width = 202
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Адм. Роль"
        Me.ColumnHeader10.Width = 81
        '
        'UserListViewContextMenuStrip
        '
        Me.UserListViewContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyFirstHashMenuItem, Me.CopySecondHashMenuItem})
        Me.UserListViewContextMenuStrip.Name = "UserListViewContextMenuStrip"
        Me.UserListViewContextMenuStrip.Size = New System.Drawing.Size(217, 48)
        Me.UserListViewContextMenuStrip.Text = "Выделенный элемент"
        '
        'CopyFirstHashMenuItem
        '
        Me.CopyFirstHashMenuItem.Name = "CopyFirstHashMenuItem"
        Me.CopyFirstHashMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.CopyFirstHashMenuItem.Text = "Скопировать первый хэш"
        '
        'CopySecondHashMenuItem
        '
        Me.CopySecondHashMenuItem.Name = "CopySecondHashMenuItem"
        Me.CopySecondHashMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.CopySecondHashMenuItem.Text = "Скопировать второй хэш"
        '
        'LabelDatabaseVersion
        '
        Me.LabelDatabaseVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelDatabaseVersion.AutoSize = True
        Me.LabelDatabaseVersion.Location = New System.Drawing.Point(615, 349)
        Me.LabelDatabaseVersion.Name = "LabelDatabaseVersion"
        Me.LabelDatabaseVersion.Size = New System.Drawing.Size(159, 13)
        Me.LabelDatabaseVersion.TabIndex = 26
        Me.LabelDatabaseVersion.Text = "Формат файла базы данных: "
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(5, 349)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(529, 20)
        Me.TextBox3.TabIndex = 23
        Me.TextBox3.Text = "Для чтения файла требуется монопольный доступ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Путь к файлу базы данных *.1CD"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.SQLPassword)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.SQLLogin)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.SQLDatabase)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.SQLInstance)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.SQLServer)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.SQLUserList)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(856, 370)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "SQL база"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(5, 349)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(529, 20)
        Me.TextBox1.TabIndex = 33
        Me.TextBox1.Text = "Программа работает только с Microsoft SQL Server"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(433, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Пароль"
        '
        'SQLPassword
        '
        Me.SQLPassword.Location = New System.Drawing.Point(433, 25)
        Me.SQLPassword.Name = "SQLPassword"
        Me.SQLPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SQLPassword.Size = New System.Drawing.Size(100, 20)
        Me.SQLPassword.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(327, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Пользователь"
        '
        'SQLLogin
        '
        Me.SQLLogin.Location = New System.Drawing.Point(327, 25)
        Me.SQLLogin.Name = "SQLLogin"
        Me.SQLLogin.Size = New System.Drawing.Size(100, 20)
        Me.SQLLogin.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(221, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Название базы"
        '
        'SQLDatabase
        '
        Me.SQLDatabase.Location = New System.Drawing.Point(221, 25)
        Me.SQLDatabase.Name = "SQLDatabase"
        Me.SQLDatabase.Size = New System.Drawing.Size(100, 20)
        Me.SQLDatabase.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(115, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Экземпляр SQL"
        '
        'SQLInstance
        '
        Me.SQLInstance.Location = New System.Drawing.Point(115, 25)
        Me.SQLInstance.Name = "SQLInstance"
        Me.SQLInstance.Size = New System.Drawing.Size(100, 20)
        Me.SQLInstance.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Адрес сервера"
        '
        'SQLServer
        '
        Me.SQLServer.Location = New System.Drawing.Point(9, 25)
        Me.SQLServer.Name = "SQLServer"
        Me.SQLServer.Size = New System.Drawing.Size(100, 20)
        Me.SQLServer.TabIndex = 23
        '
        'SQLUserList
        '
        Me.SQLUserList.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.SQLUserList.AllowDrop = True
        Me.SQLUserList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SQLUserList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.SQLUserList.ContextMenuStrip = Me.SQLUserListViewContextMenuStrip
        Me.SQLUserList.FullRowSelect = True
        Me.SQLUserList.HideSelection = False
        Me.SQLUserList.LabelEdit = True
        Me.SQLUserList.LabelWrap = False
        Me.SQLUserList.Location = New System.Drawing.Point(8, 53)
        Me.SQLUserList.MultiSelect = False
        Me.SQLUserList.Name = "SQLUserList"
        Me.SQLUserList.Size = New System.Drawing.Size(841, 290)
        Me.SQLUserList.TabIndex = 20
        Me.SQLUserList.UseCompatibleStateImageBehavior = False
        Me.SQLUserList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "GUID"
        Me.ColumnHeader1.Width = 216
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Имя пользователя"
        Me.ColumnHeader2.Width = 126
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Хэш пароля в нижнем регистре"
        Me.ColumnHeader4.Width = 195
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Хэш пароля в верхнем регистре"
        Me.ColumnHeader5.Width = 202
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Адм. Роль"
        Me.ColumnHeader6.Width = 80
        '
        'SQLUserListViewContextMenuStrip
        '
        Me.SQLUserListViewContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SQLCopyFirstHashMenuItem, Me.SQLCopySecondHashMenuItem})
        Me.SQLUserListViewContextMenuStrip.Name = "UserListViewContextMenuStrip"
        Me.SQLUserListViewContextMenuStrip.Size = New System.Drawing.Size(217, 48)
        Me.SQLUserListViewContextMenuStrip.Text = "Выделенный элемент"
        '
        'SQLCopyFirstHashMenuItem
        '
        Me.SQLCopyFirstHashMenuItem.Name = "SQLCopyFirstHashMenuItem"
        Me.SQLCopyFirstHashMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.SQLCopyFirstHashMenuItem.Text = "Скопировать первый хэш"
        '
        'SQLCopySecondHashMenuItem
        '
        Me.SQLCopySecondHashMenuItem.Name = "SQLCopySecondHashMenuItem"
        Me.SQLCopySecondHashMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.SQLCopySecondHashMenuItem.Text = "Скопировать второй хэш"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(6, 406)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(863, 49)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Открыть сайт для расшифровки хэшей"
        Me.ToolTip1.SetToolTip(Me.Button1, "https://hashkiller.co.uk/sha1-decrypter.aspx")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Application
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 460)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Просмотр хэшей паролей пользователей 1С"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.UserListViewContextMenuStrip.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.SQLUserListViewContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents FileIB As TextBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents ButtonGetUsers As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents SQLUserList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LabelDatabaseVersion As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SQLServer As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents SQLPassword As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents SQLLogin As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SQLDatabase As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SQLInstance As TextBox
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ListViewUsers As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents UserListViewContextMenuStrip As ContextMenuStrip
    Friend WithEvents CopyFirstHashMenuItem As ToolStripMenuItem
    Friend WithEvents CopySecondHashMenuItem As ToolStripMenuItem
    Friend WithEvents SQLUserListViewContextMenuStrip As ContextMenuStrip
    Friend WithEvents SQLCopyFirstHashMenuItem As ToolStripMenuItem
    Friend WithEvents SQLCopySecondHashMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
