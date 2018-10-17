using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNoInterfaceSeg.Model.Entities
{
    public class Test
    {
        public Guid Id { get; set; }
        public Student Owner { get; set; }
    }
}
