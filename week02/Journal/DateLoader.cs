using System;

public class DateLoader
{
    public DateTime _theCurrentDateTime = DateTime.Now;
    
    public string GetDateText()
    {
        return _theCurrentDateTime.ToShortDateString();
    }
}