using System;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Core;

namespace WizardControlExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Wizard_Cancel(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = (DXMessageBox.Show("Cancel installation and close wizard?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.No);
        }
    }
}
