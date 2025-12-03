namespace Domain.Shared;

public static class DateTimeProvider
{
    public static DateTime CurrentDateTime()
    {
        return DateTime.Now.ToLocalTime();
    }
}