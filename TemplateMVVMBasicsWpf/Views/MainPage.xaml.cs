using System.Windows.Controls;

using TemplateMVVMBasicsWpf.ViewModels;

namespace TemplateMVVMBasicsWpf.Views
{
    public partial class MainPage : Page
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
