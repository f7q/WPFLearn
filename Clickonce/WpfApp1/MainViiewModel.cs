using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class MainViiewModel
    {
        public string Version
        {
            get
            {
                if (!ApplicationDeployment.IsNetworkDeployed) return string.Empty;

                var version = ApplicationDeployment.CurrentDeployment.CurrentVersion;
                return (
                version.Major.ToString() + "." +
                version.Minor.ToString() + "." +
                version.Build.ToString() + "." +
                version.Revision.ToString()
　　　　　　    );
            }
        }
    }
}
