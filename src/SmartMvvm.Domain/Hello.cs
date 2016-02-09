using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMvvm.Domain
{
    public class Hello
    {
        public string Name { get; set; }
        
        public Hello(string name)
        {
            Debug.WriteLine(GetType().Name + " created.");
            Name = name;
        }

        public string SayHello()
        {
            return "Hello " + Name;
        }
    }
}
