using System.Windows.Controls;

using TemplateMVVMBasicsWpf.ViewModels;

namespace TemplateMVVMBasicsWpf.Views
{
    public partial class BlankPage : Page
    {
        public BlankPage(BlankViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
