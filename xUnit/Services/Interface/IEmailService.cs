namespace xUnit.Services.Interface
{
    public interface IEmailService
    {
        bool EmailExists(); 
        bool SendEmail();
    }
}
