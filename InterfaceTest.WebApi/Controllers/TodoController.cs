using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using InterfaceTest.WebApi.Entities;
using InterfaceTest.WebApi.Interfaces;
using InterfaceTest.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace InterfaceTest.WebApi.Controllers
{
  [ApiController]
  [Route("todos")]
  public class TodoController : ControllerBase
  {
    private readonly ITodoService _todoService;

    public TodoController(ITodoService todoService)
    {
      this._todoService = todoService;
    }

    [HttpGet]
    [Route("")]
    public async Task<List<Todo>> List()
    {
      var todos = await this._todoService.ListAllTodos();

      return todos;
    }

    [HttpGet]
    [Route("completed")]
    public async Task<List<Todo>> ListCompleted()
    {
      var todos = await this._todoService.ListAllTodos();

      todos = todos.Where(todo => todo.Completed).ToList();

      return todos;
    }

    [HttpGet]
    [Route("uncompleted")]
    public async Task<List<Todo>> ListUncompleted()
    {
      var todos = await this._todoService.ListAllTodos();

      todos = todos.Where(todo => !todo.Completed).ToList();

      return todos;
    }
  }
}
