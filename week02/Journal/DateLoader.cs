using System;

public class DateLoader
{
    public DateTime _theCurrentDateTime = DateTime.Now;
    
    public string getDateText()
    {
        return _theCurrentDateTime.ToShortDateString();
    }
}