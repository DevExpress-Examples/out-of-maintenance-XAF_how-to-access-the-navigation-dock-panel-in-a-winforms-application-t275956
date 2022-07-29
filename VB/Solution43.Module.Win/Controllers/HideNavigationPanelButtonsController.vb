Imports System
Imports System.Windows.Forms
Imports DevExpress.ExpressApp

Namespace Solution43.Module.Win.Controllers

    ' For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    Public Class HideNavigationPanelButtonsController
        Inherits WindowController

        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            AddHandler Frame.TemplateChanged, AddressOf Frame_TemplateChanged
        End Sub

        Private Sub Frame_TemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim form As Form = CType(Frame.Template, Form)
            AddHandler form.Load, AddressOf Form_Load
        End Sub

        Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs)
            If TypeOf Frame.Template Is DevExpress.ExpressApp.Win.Templates.INavigationPanelHolder Then
                Dim navigationPanel As DevExpress.XtraBars.Docking.DockPanel = CType(Frame.Template, DevExpress.ExpressApp.Win.Templates.INavigationPanelHolder).DockPanelNavigation
                navigationPanel.Options.ShowAutoHideButton = False
                navigationPanel.Options.ShowCloseButton = False
            End If
        End Sub

        Protected Overrides Sub OnDeactivated()
            RemoveHandler Frame.TemplateChanged, AddressOf Frame_TemplateChanged
            MyBase.OnDeactivated()
        End Sub
    End Class
End Namespace
