using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace Seminar07
{
    [System.AttributeUsage(System.AttributeTargets.Field)]
    public class CustomNameAttribute : System.Attribute
    {
        public string CustomName { get; }
        public CustomNameAttribute(string name)
        {
            CustomName = name;
        }
    }
}






