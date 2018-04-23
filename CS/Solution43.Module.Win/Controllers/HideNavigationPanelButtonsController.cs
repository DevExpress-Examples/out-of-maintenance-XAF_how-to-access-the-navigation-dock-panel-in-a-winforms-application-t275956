using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.ExpressApp;

namespace Solution43.Module.Win.Controllers {
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public class HideNavigationPanelButtonsController : WindowController {
        protected override void OnActivated() {
            base.OnActivated();
            Frame.TemplateChanged += Frame_TemplateChanged;
        }
        private void Frame_TemplateChanged(object sender, EventArgs e) {
            Form form = (Form)Frame.Template;
            form.Load += Form_Load;
        }
        private void Form_Load(object sender, EventArgs e) {
            if(Frame.Template is DevExpress.ExpressApp.Win.Templates.INavigationPanelHolder) {
                DevExpress.XtraBars.Docking.DockPanel navigationPanel = ((DevExpress.ExpressApp.Win.Templates.INavigationPanelHolder)Frame.Template).DockPanelNavigation;
                navigationPanel.Options.ShowAutoHideButton = false;
                navigationPanel.Options.ShowCloseButton = false;
            }
        }
        protected override void OnDeactivated() {
            Frame.TemplateChanged -= Frame_TemplateChanged;
            base.OnDeactivated();
        }
    }
}
