namespace SolidNaPratica._05_DIP.Good;

public interface INotificationService
{
    void Notify(string message);
}

public class EmailService : INotificationService
{
    public void Notify(string message)
    {
        Console.WriteLine("Sending email: " + message);
    }
}

public class SMSService : INotificationService
{
    public void Notify(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }
}

public class UserService
{
    private readonly INotificationService _notificationService;

    public UserService(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void NotifyUser(string message)
    {
        _notificationService.Notify(message);
    }
}
