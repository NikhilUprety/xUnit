using Microsoft.AspNetCore.Mvc;
using xUnit.Services.Interface;

namespace xUnit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IPrinterService _printerService;
        private readonly IEmailService _emailService;

        public HomeController(IEmailService emailService,IPrinterService printerService)
        {

            _emailService = emailService;
            _printerService = printerService;

        }
        [HttpGet("index/{guessedNumber}")]        
        
        public  string Index(int guessedNumber)
        {
            string result;
            if (guessedNumber < 100)
            {
                result = "wrong ! Try a bigger number ";
            }
            else if (guessedNumber > 100) 
            {
                result = "wrong ! Try a smaller number";
            }
            else
            {
                result = "correct ! you guessed the number";
            }
            if (_emailService.EmailExists()) { 
                 _emailService.SendEmail();
            }
            if (_printerService.IsPrintAvailable())
            {
                _printerService.Print();
            }
            return result;
        }
    }
}
