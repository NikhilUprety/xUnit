using xUnit.Services.Interface;

namespace xUnit.Services.Implementation
{
    public class PrinterService : IPrinterService
    {

        bool IPrinterService.IsPrintAvailable()
        {
            throw new NotImplementedException();
        }

        void IPrinterService.Print()
        {
            throw new NotImplementedException();
        }
    }
}
