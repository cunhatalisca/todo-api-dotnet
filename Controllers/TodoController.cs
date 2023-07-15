using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.models;
namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    private TodoContext dbContext;
    public TodoController(TodoContext _dbContext) {
        dbContext = _dbContext;
    }

    [HttpGet]
    public async Task<List<Todo>> getTodo() {
        return await dbContext.TodoItems.ToListAsync();
    }

    [HttpPost]
    public async Task<Todo> postTodo([FromBody] Todo todo){
        await dbContext.TodoItems.AddAsync(todo);
        return todo;
    }

    [HttpDelete]
    public async Task<ActionResult> deleteTodo([FromQuery] long id)
  {
    var findTodo = await dbContext.TodoItems.FindAsync(id);

    if (!findTodo.Equals(null)) 
    {
        dbContext.TodoItems.Remove(findTodo);
        return NoContent();
    }

    return NotFound();    
  }

    [HttpPut]
    public async Task putTodo([FromBody] UpdateTodoDTO name, [FromQuery] long id)
}

