using System.Windows.Controls;

namespace TemplateMVVMBasicsWpf.Contracts.Views
{
    public interface IShellWindow
    {
        Frame GetNavigationFrame();

        void ShowWindow();

        void CloseWindow();
    }
}
