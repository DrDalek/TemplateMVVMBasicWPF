using System;
using System.Diagnostics;
using System.Reflection;

using TemplateMVVMBasicsWpf.Contracts.Services;

namespace TemplateMVVMBasicsWpf.Services
{
    public class ApplicationInfoService : IApplicationInfoService
    {
        public ApplicationInfoService()
        {
        }

        public Version GetVersion()
        {
            // Set the app version in TemplateMVVMBasicsWpf > Properties > Package > PackageVersion
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            var version = FileVersionInfo.GetVersionInfo(assemblyLocation).FileVersion;
            return new Version(version);
        }
    }
}
