using System;


namespace TodoApi.Models;

public class Utility
{

  private readonly TodoContext _dbContext;

  public Utility(TodoContext dbContext)
  {
      _dbContext = dbContext;
  }

  public bool FillTodosList() {
    TodoItem item1 = new TodoItem(
      "Philippines Trip",
      "Organize internal flights, hotels, routes, etc."
    );

    TodoItem item2 = new TodoItem(
      "Paint the house",
      "It's time to paint the house, lets paint it yellow!"
    );

    TodoItem item3 = new TodoItem(
      "Learn new technologies",
      "Take time to explore new languages, and play around with them"
    );

    List<TodoItem> list = [item1, item2, item3];

    foreach (TodoItem item in list){
      _dbContext.TodoItems.Add(item);
    }

    _dbContext.SaveChanges();

    return true;
  }

}
