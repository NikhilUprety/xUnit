using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnit.Controllers;
using xUnit.Services.Implementation;
using xUnit.Services.Interface;
using Xunit;

namespace xUnit.Tests.Controllers
{
    public class HomeControllerTest
    {
   

        [Fact]
        public void HomeController_Index_ValidLargeNumberResult() 
        {
        
         IPrinterService printerService = new PrinterService();       
         IEmailService emailService = new EmailService();       

         HomeController controller = new HomeController(emailService,printerService);
         int guessedNumber = 122;
         string expectedResult = "wrong ! Try a smaller number";

         string result = controller.Index(guessedNumber);

         Assert.Equal(result,expectedResult);




        }

    }
}
