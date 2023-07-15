using Microsoft.AspNetCore.Mvc;

namespace TodoApi.models;

public class Todo {
  private string name { get; set; }
  private long id { get; set; }
  private bool isCompleted { get; set; }
  

  public Todo (string _name) {
      name = _name;
  }
}