Imports System.Data.SqlClient
Imports System.Security.Principal

Public Class MainForm

    Dim TableParams As AccessFunctions.PageParams

    Structure SQLUser
        Dim ID As Byte()
        Dim IDStr As String
        Dim Name As String
        Dim Descr As String
        Dim Data As Byte()
        Dim DataStr As String
        Dim PassHash As String
        Dim PassHash2 As String
        Dim AdmRole As String
        Dim KeySize As Integer
        Dim KeyData As Byte()
    End Structure

    Dim SQLUsers As List(Of SQLUser) = New List(Of SQLUser)

    Public Sub New()

        InitializeComponent()

        'кусочек говнокода для стимула оптимизировать приложение
        SQLServer_Leave(SQLServer, Nothing)
        SQLInstance_Leave(SQLInstance, Nothing)
        SQLDatabase_Leave(SQLDatabase, Nothing)
        SQLLogin_Leave(SQLLogin, Nothing)
        SQLPassword_Leave(SQLPassword, Nothing)

    End Sub

    Private Shared Function ShowWarning() As Boolean

        Return True

    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            FileIB.Text = OpenFileDialog.FileName
            GetUsers()
        End If

    End Sub

    Private Sub ButtonGetUsers_Click(sender As Object, e As EventArgs) Handles ButtonGetUsers.Click

        If FileIB.Text.Length <> 0 Then
            GetUsers()
        End If

    End Sub

    Sub GetUsers()

        ListViewUsers.Items.Clear()

        Try

            TableParams = AccessFunctions.ReadInfoBase(FileIB.Text, "V8USERS")

            LabelDatabaseVersion.Text = "Формат файла базы данных: " + TableParams.DatabaseVersion

        Catch ex As Exception

            TableParams = Nothing

            MsgBox("Ошибка при попытке чтения данных из файла информационной базы:" + vbNewLine + ex.Message, MsgBoxStyle.Critical, "Ошибка работы с файлом")

            Exit Sub

        End Try

        If TableParams.Records Is Nothing Then
            Exit Sub
        End If

        For Each Row In TableParams.Records

            If Row("NAME").ToString = "" Then
                Row.Add("UserGuidStr", "")
                Row.Add("UserPassHash", "")
                Row.Add("UserPassHash2", "")
                Continue For
            End If

            Dim AuthStructure = ParserServices.ParsesClass.ParseString(Row("DATA"))

            'Dim PassHash = Replace(AuthStructure(0)(11).ToString, """", "")
            'Dim PassHash2 = Replace(AuthStructure(0)(12).ToString, """", "")

            Dim G = New Guid(DirectCast(Row("ID"), Byte()))

            Row.Add("UserGuidStr", G.ToString)

            'pretty crapy code here..
            If AuthStructure(0)(7) = "0" Then
                Row.Add("UserPassHash", "---")
                Row.Add("UserPassHash2", "---")
            Else
                If AuthStructure(0).Count = 17 Or TableParams.DatabaseVersion = "8.3.8" Then
                    Row.Add("UserPassHash", Replace(AuthStructure(0)(11).ToString, """", ""))
                    Row.Add("UserPassHash2", Replace(AuthStructure(0)(12).ToString, """", ""))
                Else
                    Row.Add("UserPassHash", Replace(AuthStructure(0)(11).ToString, """", ""))
                    Row.Add("UserPassHash2", Replace(AuthStructure(0)(12).ToString, """", ""))
                End If
            End If


            Dim itemUserList = New ListViewItem(Row("NAME").ToString)

            'itemUserList.SubItems.Add(PassHash)
            'itemUserList.SubItems.Add(PassHash2)
            itemUserList.SubItems.Add(Row("UserPassHash").ToString)
            itemUserList.SubItems.Add(Row("UserPassHash2").ToString)
            itemUserList.SubItems.Add(IIf(Row("ADMROLE"), "Да", ""))

            ListViewUsers.Items.Add(itemUserList)

        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        GetUsersSQL()

    End Sub

    Sub GetUsersSQL()

        SQLUsers.Clear()
        SQLUserList.Items.Clear()

        Try

            'MVS++
            Dim ConnectionString As String = "Data Source=" + SQLInstance.Text + ";Server=" + SQLServer.Text + ";Database=" + SQLDatabase.Text + ";User=""" + SQLLogin.Text + """;Password=""" + SQLPassword.Text + """;"
            'MVS--

            Dim Connection = New SqlConnection(ConnectionString)
            Connection.Open()

            Dim command As New SqlCommand("SELECT [ID], [Name], [Descr], [Data], [AdmRole] FROM [dbo].[v8users] ORDER BY [Name]", Connection)

            Dim reader = command.ExecuteReader()

            While reader.Read

                Try

                    Dim SQLUser = New SQLUser
                    SQLUser.ID = reader.GetSqlBinary(0)
                    SQLUser.Name = reader.GetString(1)
                    SQLUser.Descr = reader.GetString(2)
                    SQLUser.Data = reader.GetSqlBinary(3)
                    SQLUser.AdmRole = IIf(BitConverter.ToBoolean(reader.GetSqlBinary(4), 0), "Да", "")

                    SQLUser.IDStr = New Guid(SQLUser.ID).ToString
                    SQLUser.DataStr = CommonModule.DecodePasswordStructure(SQLUser.Data, SQLUser.KeySize, SQLUser.KeyData)

                    Dim AuthStructure = ParserServices.ParsesClass.ParseString(SQLUser.DataStr)

                    If AuthStructure(0)(7).ToString = "0" Then
                        'нет авторизации 1С
                        SQLUser.PassHash = "---"
                    Else
                        If AuthStructure(0).Count = 17 Then
                            SQLUser.PassHash = Replace(AuthStructure(0)(11).ToString, """", "")
                            SQLUser.PassHash2 = Replace(AuthStructure(0)(12).ToString, """", "")
                        Else
                            SQLUser.PassHash = Replace(AuthStructure(0)(11).ToString, """", "")
                            SQLUser.PassHash2 = Replace(AuthStructure(0)(12).ToString, """", "")
                        End If
                    End If

                    SQLUsers.Add(SQLUser)

                Catch ex As Exception

                End Try

            End While

            reader.Close()

        Catch ex As Exception

            MsgBox("Ошибка при попытке чтения пользователей из базы данных:" + vbNewLine + ex.Message, MsgBoxStyle.Critical, "Ошибка работы с базой данных")

            Exit Sub

        End Try

        '*****************************************************
        'Заполнение списка пользователей

        For Each Row In SQLUsers

            If String.IsNullOrEmpty(Row.Name) Then
                Continue For
            End If

            Dim itemUserList = New ListViewItem(Row.Name)

            itemUserList.SubItems.Add(Row.PassHash)
            itemUserList.SubItems.Add(Row.PassHash2)
            itemUserList.SubItems.Add(Row.AdmRole)

            SQLUserList.Items.Add(itemUserList)

        Next
        '*****************************************************

    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        If Not ShowWarning() Then

            Application.Exit()

        End If

    End Sub

    Private Sub CopyFirstHashMenuItem_Click(sender As Object, e As EventArgs) Handles CopyFirstHashMenuItem.Click
        Clipboard.SetText(ListViewUsers.SelectedItems(0).SubItems(2).Text)
    End Sub

    Private Sub CopySecondHashMenuItem_Click(sender As Object, e As EventArgs) Handles CopySecondHashMenuItem.Click
        Clipboard.SetText(ListViewUsers.SelectedItems(0).SubItems(3).Text)
    End Sub

    Private Sub SQLCopyFirstHashMenuItem_Click(sender As Object, e As EventArgs) Handles SQLCopyFirstHashMenuItem.Click
        Clipboard.SetText(SQLUserList.SelectedItems(0).SubItems(2).Text)
    End Sub

    Private Sub SQLCopySecondHashMenuItem_Click(sender As Object, e As EventArgs) Handles SQLCopySecondHashMenuItem.Click
        Clipboard.SetText(SQLUserList.SelectedItems(0).SubItems(3).Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://hashkiller.co.uk/sha1-decrypter.aspx")
    End Sub

    Private Sub SQLServer_Enter(sender As Object, e As EventArgs) Handles SQLServer.Enter
        If Not CBool(CType(sender, TextBox).Tag) Then
            CType(sender, TextBox).Text = String.Empty
            CType(sender, TextBox).ForeColor = Color.Black
            CType(sender, TextBox).Tag = True
        End If
    End Sub

    Private Sub SQLServer_Leave(sender As Object, e As EventArgs) Handles SQLServer.Leave
        If CType(sender, TextBox).Text.Trim() = String.Empty Then
            CType(sender, TextBox).Text = "192.168.1.1"
            CType(sender, TextBox).ForeColor = Color.LightGray
            CType(sender, TextBox).Tag = False
        End If
    End Sub

    Private Sub SQLInstance_Enter(sender As Object, e As EventArgs) Handles SQLInstance.Enter
        If Not CBool(CType(sender, TextBox).Tag) Then
            CType(sender, TextBox).Text = String.Empty
            CType(sender, TextBox).ForeColor = Color.Black
            CType(sender, TextBox).Tag = True
        End If
    End Sub

    Private Sub SQLInstance_Leave(sender As Object, e As EventArgs) Handles SQLInstance.Leave
        If CType(sender, TextBox).Text.Trim() = String.Empty Then
            CType(sender, TextBox).Text = "MSSQLSERVER"
            CType(sender, TextBox).ForeColor = Color.LightGray
            CType(sender, TextBox).Tag = False
        End If
    End Sub

    Private Sub SQLDatabase_Enter(sender As Object, e As EventArgs) Handles SQLDatabase.Enter
        If Not CBool(CType(sender, TextBox).Tag) Then
            CType(sender, TextBox).Text = String.Empty
            CType(sender, TextBox).ForeColor = Color.Black
            CType(sender, TextBox).Tag = True
        End If
    End Sub

    Private Sub SQLDatabase_Leave(sender As Object, e As EventArgs) Handles SQLDatabase.Leave
        If CType(sender, TextBox).Text.Trim() = String.Empty Then
            CType(sender, TextBox).Text = "1C_Base"
            CType(sender, TextBox).ForeColor = Color.LightGray
            CType(sender, TextBox).Tag = False
        End If
    End Sub

    Private Sub SQLLogin_Enter(sender As Object, e As EventArgs) Handles SQLLogin.Enter
        If Not CBool(CType(sender, TextBox).Tag) Then
            CType(sender, TextBox).Text = String.Empty
            CType(sender, TextBox).ForeColor = Color.Black
            CType(sender, TextBox).Tag = True
        End If
    End Sub

    Private Sub SQLLogin_Leave(sender As Object, e As EventArgs) Handles SQLLogin.Leave
        If CType(sender, TextBox).Text.Trim() = String.Empty Then
            CType(sender, TextBox).Text = "sa"
            CType(sender, TextBox).ForeColor = Color.LightGray
            CType(sender, TextBox).Tag = False
        End If
    End Sub

    Private Sub SQLPassword_Enter(sender As Object, e As EventArgs) Handles SQLPassword.Enter
        If Not CBool(CType(sender, TextBox).Tag) Then
            CType(sender, TextBox).Text = String.Empty
            CType(sender, TextBox).ForeColor = Color.Black
            CType(sender, TextBox).Tag = True
        End If
    End Sub

    Private Sub SQLPassword_Leave(sender As Object, e As EventArgs) Handles SQLPassword.Leave
        If CType(sender, TextBox).Text.Trim() = String.Empty Then
            CType(sender, TextBox).Text = "********"
            CType(sender, TextBox).ForeColor = Color.LightGray
            CType(sender, TextBox).Tag = False
        End If
    End Sub
End Class
