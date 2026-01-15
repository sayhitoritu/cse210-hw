using System;

public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";

    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }

    public string ToFileString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split("|");

        Entry entry = new Entry();
        entry._date = parts[0];
        entry._promptText = parts[1];
        entry._entryText = parts[2];

        return entry;
    }
}
