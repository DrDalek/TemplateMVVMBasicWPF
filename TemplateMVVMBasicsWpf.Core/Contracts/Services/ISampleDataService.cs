using System.Collections.Generic;
using System.Threading.Tasks;

using TemplateMVVMBasicsWpf.Core.Models;

namespace TemplateMVVMBasicsWpf.Core.Contracts.Services
{
    public interface ISampleDataService
    {
        Task<IEnumerable<SampleOrder>> GetMasterDetailDataAsync();
    }
}
