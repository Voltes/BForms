using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BForms.Utilities
{
    public class BsResources
    {
        public BsResources()
        {
            foreach (var prop in this.GetType().GetProperties())
            {
                prop.SetValue(this, BsResourceManager.Resource(prop.Name));
            }
        }
    }
}
