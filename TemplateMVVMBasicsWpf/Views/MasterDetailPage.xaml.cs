using System.Windows.Controls;

using TemplateMVVMBasicsWpf.ViewModels;

namespace TemplateMVVMBasicsWpf.Views
{
    public partial class MasterDetailPage : Page
    {
        public MasterDetailPage(MasterDetailViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
