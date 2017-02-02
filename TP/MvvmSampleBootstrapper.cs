using Prism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    internal class MvvmSampleBootstrapper : Bootstrapper
    {
        /// <summary>
        /// Run the bootstrapper process.
        /// </summary>
        /// <param name="runWithDefaultConfiguration">If <see langword="true"/>, registers default 
        ///             Prism Library services in the container. This is the default behavior.</param>
        public override void Run(bool runWithDefaultConfiguration)
        {
            var loginPage = new LoginPage ();
            loginPage.ShowDialog();
        }

        /// <summary>
        /// Configures the LocatorProvider for the <see cref="T:Microsoft.Practices.ServiceLocation.ServiceLocator"/>.
        /// </summary>
        protected override void ConfigureServiceLocator()
        {
        }
    }
}
