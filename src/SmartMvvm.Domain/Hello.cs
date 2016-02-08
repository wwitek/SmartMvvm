using System;
using System.Collections.Generic;
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
            Name = name;
        }

        public string SayHello()
        {
            return "Hello " + Name;
        }
    }
}
