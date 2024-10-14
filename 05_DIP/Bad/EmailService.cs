namespace SolidNaPratica._05_DIP.Bad;

public class EmailService
{
    public void SendEmail(string message)
    {
        Console.WriteLine("Sending email: " + message);
    }
}

public class UserService
{
    private readonly EmailService _emailService;

    public UserService(EmailService emailService)
    {
        _emailService = emailService;
    }

    public void NotifyUser(string message)
    {
        _emailService.SendEmail(message);
    }
}
