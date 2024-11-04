using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnit.Services.Interface;

namespace xUnit.Tests.ServicesMock
{
    public class MockEmailService : IEmailService
    {
        public bool EmailExists()
        {
            return true;
        }

        public void SendEmail()
        {
            //
        }
    }
}
