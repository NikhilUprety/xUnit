using xUnit.Services.Interface;

namespace xUnit.Services.Implementation
{
    public class EmailService : IEmailService
    {
        public bool EmailExists()
        {
            return true;
        }

        public void SendEmail()
        {
            throw new NotImplementedException();
        }
    }
}
