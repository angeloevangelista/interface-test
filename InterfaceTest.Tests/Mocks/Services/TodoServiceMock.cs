using System.Collections.Generic;
using System.Threading.Tasks;
using InterfaceTest.WebApi.Entities;
using InterfaceTest.WebApi.Interfaces;

namespace InterfaceTest.Tests.Mocks.Services
{
  public class TodoServiceMock : ITodoService
  {
    private readonly List<Todo> _todos;

    public TodoServiceMock()
    {
      this._todos = new List<Todo>() {
        new Todo() {
          Id = 1,
          Title = "delectus aut autem",
          Completed = false,
        },
        new Todo() {
          Id = 2,
          Title = "quis ut nam facilis et officia qui",
          Completed = false,
        },
        new Todo() {
          Id = 3,
          Title = "fugiat veniam minus",
          Completed = false,
        },
        new Todo() {
          Id = 4,
          Title = "et porro tempora",
          Completed = true,
        },
        new Todo() {
          Id = 5,
          Title = "laboriosam mollitia et enim quasi adipisci quia provident illum",
          Completed = false,
        },
        new Todo() {
          Id = 6,
          Title = "qui ullam ratione quibusdam voluptatem quia omnis",
          Completed = false,
        },
        new Todo() {
          Id = 7,
          Title = "illo expedita consequatur quia in",
          Completed = false,
        },
        new Todo() {
          Id = 8,
          Title = "quo adipisci enim quam ut ab",
          Completed = true,
        },
        new Todo() {
          Id = 9,
          Title = "molestiae perspiciatis ipsa",
          Completed = false,
        },
        new Todo() {
          Id = 10,
          Title = "illo est ratione doloremque quia maiores aut",
          Completed = true,
        },
        new Todo() {
          Id = 11,
          Title = "vero rerum temporibus dolor",
          Completed = true,
        },
        new Todo() {
          Id = 12,
          Title = "ipsa repellendus fugit nisi",
          Completed = true,
        },
        new Todo() {
          Id = 13,
          Title = "et doloremque nulla",
          Completed = false,
        },
        new Todo() {
          Id = 14,
          Title = "repellendus sunt dolores architecto voluptatum",
          Completed = true,
        },
        new Todo() {
          Id = 15,
          Title = "ab voluptatum amet voluptas",
          Completed = true,
        },
        new Todo() {
          Id = 16,
          Title = "accusamus eos facilis sint et aut voluptatem",
          Completed = true,
        },
        new Todo() {
          Id = 17,
          Title = "quo laboriosam deleniti aut qui",
          Completed = true,
        },
        new Todo() {
          Id = 18,
          Title = "dolorum est consequatur ea mollitia in culpa",
          Completed = false,
        },
        new Todo() {
          Id = 19,
          Title = "molestiae ipsa aut voluptatibus pariatur dolor nihil",
          Completed = true,
        },
        new Todo() {
          Id = 20,
          Title = "ullam nobis libero sapiente ad optio sint",
          Completed = true,
        }
      };
    }

    public async Task<List<Todo>> ListAllTodos()
    {
      return this._todos;
    }
  }
}