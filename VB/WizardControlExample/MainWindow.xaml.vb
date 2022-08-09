Imports System.Windows
Imports DevExpress.Xpf.Core

Namespace WizardControlExample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Wizard_Cancel(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            e.Cancel = DXMessageBox.Show("Cancel installation and close wizard?", "Confirmation", MessageBoxButton.YesNo) = MessageBoxResult.No
        End Sub
    End Class
End Namespace
