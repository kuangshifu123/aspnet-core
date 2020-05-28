using System;
using System.Collections.Generic;
using System.Text;

namespace SnkrsMonitor
{
    public class HelloWorldService : ServiceBase, IHelloWorldService
    {
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
