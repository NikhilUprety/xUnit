using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnit.Services.Interface;

namespace xUnit.Tests.ServicesMock
{
    public class MockPrinterService : IPrinterService
    {
        public bool IsPrintAvailable()
        {
            return true;
        }

        public void Print()
        {
            //
        }
    }
}
