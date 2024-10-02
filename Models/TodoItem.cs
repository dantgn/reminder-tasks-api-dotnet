using System;

namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }

    public TodoItem(string? title, string? description)
    {
        Title = title;
        Description = description;
    }

}