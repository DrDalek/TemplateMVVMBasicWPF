using TemplateMVVMBasicsWpf.Models;

namespace TemplateMVVMBasicsWpf.Contracts.Services
{
    public interface IThemeSelectorService
    {
        bool SetTheme(AppTheme? theme = null);

        AppTheme GetCurrentTheme();
    }
}
