using Microsoft.AspNetCore.Authorization.Infrastructure;
using Moq;
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
    
      private readonly HomeController _controller=null;
      private readonly Mock<IEmailService> _emailService =new Mock<IEmailService>();
      private readonly Mock<IPrinterService> _printerService =new Mock<IPrinterService>();

        public HomeControllerTest()
        {
            _controller=new HomeController(_emailService.Object, _printerService.Object);
        }

        [Fact]
        public void HomeController_Index_ValidLargeNumberResult() 
        {
        //Arrange
        
         _printerService.Setup(x=>x.IsPrintAvailable()).Returns(true);     
         _emailService.Setup(x => x.EmailExists()).Returns(true);

   
         int guessedNumber = 122;
         string expectedResult = "wrong ! Try a smaller number";
 
        //Act
         string result = _controller.Index(guessedNumber);

         Assert.Equal(result,expectedResult);

        }

        [Fact]
        public void HomeController_Index_ValidLargeNumberResultWithoutEmailService()
        {
            //Arrange

            _printerService.Setup(x => x.IsPrintAvailable()).Returns(true);
            _emailService.Setup(x => x.EmailExists()).Returns(false);


            int guessedNumber = 122;
            string expectedResult = "wrong ! Try a smaller number";

            string result = _controller.Index(guessedNumber);

            Assert.Equal(result, expectedResult);

        }

        [Fact]
        public void HomeController_Index_ValidSmallNumberResult()
        {
            //Arrange

            _printerService.Setup(x => x.IsPrintAvailable()).Returns(true);
            _emailService.Setup(x => x.EmailExists()).Returns(true);


            int guessedNumber =21 ;
            string expectedResult = "wrong ! Try a bigger number";

            string result = _controller.Index(guessedNumber);

            Assert.Equal(result, expectedResult);

        }

        [Fact]
        public void HomeController_Index_ValidSmallNumberResultWithoutEmailService()
        {
            //Arrange

            _printerService.Setup(x => x.IsPrintAvailable()).Returns(true);
            _emailService.Setup(x => x.EmailExists()).Returns(false);


            int guessedNumber = 1;
            string expectedResult = "wrong ! Try a bigger number";

            string result = _controller.Index(guessedNumber);

            Assert.Equal(result, expectedResult);

        }

        [Fact]
        public void HomeController_Index_ValidNumberResult()
        {
            //Arrange

            _printerService.Setup(x => x.IsPrintAvailable()).Returns(true);
            _emailService.Setup(x => x.EmailExists()).Returns(true);


            int guessedNumber = 100;
            string expectedResult = "correct ! you guessed the number";

            string result = _controller.Index(guessedNumber);

            Assert.Equal(result, expectedResult);

        }


        [Fact]
        public void HomeController_Index_ValidNumberResultWithoutEmailService()
        {
            //Arrange

            _printerService.Setup(x => x.IsPrintAvailable()).Returns(true);
            _emailService.Setup(x => x.EmailExists()).Returns(false);


            int guessedNumber = 100;
            string expectedResult = "correct ! you guessed the number";

            string result = _controller.Index(guessedNumber);

            Assert.Equal(result, expectedResult);

        }
    }
}
