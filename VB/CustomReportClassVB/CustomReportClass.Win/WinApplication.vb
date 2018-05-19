Imports System.ComponentModel
Imports DevExpress.ExpressApp.Win
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp

Namespace CustomReportClass.Win
	Partial Public Class CustomReportClassWindowsFormsApplication
		Inherits WinApplication

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub CustomReportClassWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
			e.Updater.Update()
			e.Handled = True
		End Sub
	End Class
End Namespace
