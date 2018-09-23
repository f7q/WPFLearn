using System.Deployment.Application;

namespace ViewModel
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

        public string AsembleyVersion
        {
            get
            {
                return "0.0.0.0";
            }
        }
    }
}
