using System.Windows.Controls;

using TemplateMVVMBasicsWpf.ViewModels;

namespace TemplateMVVMBasicsWpf.Views
{
    public partial class SettingsPage : Page
    {
        public SettingsPage(SettingsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
