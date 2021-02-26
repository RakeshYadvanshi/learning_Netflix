using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lamar;
namespace Netflix.Web
{
    public class ApplicationRegistry : ServiceRegistry
    {
        public ApplicationRegistry()
        {
            Scan((a) =>
            {
                a.TheCallingAssembly();
                a.WithDefaultConventions();
                a.AssembliesAndExecutablesFromApplicationBaseDirectory
                    (assembly => assembly.GetName().Name.StartsWith("Netflix."));
            });
        }
    }
}
