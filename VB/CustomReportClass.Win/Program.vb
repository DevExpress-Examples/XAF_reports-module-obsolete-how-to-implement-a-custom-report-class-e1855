Imports System.Configuration

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Win
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports CustomReportClass.Module

Namespace CustomReportClass.Win
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
#If EASYTEST Then
			DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register()
#End If
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached
			Dim winApplication As New CustomReportClassWindowsFormsApplication()
			Try
				InMemoryDataStoreProvider.Register()
				winApplication.ConnectionString = InMemoryDataStoreProvider.ConnectionString
				winApplication.Setup()
				winApplication.Start()
			Catch e As Exception
				winApplication.HandleException(e)
			End Try
		End Sub
	End Class
End Namespace
