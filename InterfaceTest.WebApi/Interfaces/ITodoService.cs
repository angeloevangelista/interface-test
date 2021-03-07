using System.Collections.Generic;
using System.Threading.Tasks;
using InterfaceTest.WebApi.Entities;

namespace InterfaceTest.WebApi.Interfaces
{
  public interface ITodoService
  {
    Task<List<Todo>> ListAllTodos();
  }
}