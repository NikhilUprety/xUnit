namespace xUnit.Services.Interface
{
    public interface IEmailService
    {
        bool EmailExists(); 
        void SendEmail();
    }
}
