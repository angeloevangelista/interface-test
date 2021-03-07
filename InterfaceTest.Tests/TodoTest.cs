using System.Linq;
using InterfaceTest.Tests.Mocks.Services;
using InterfaceTest.WebApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterfaceTest.Tests
{
  [TestClass]
  public class TodoTest
  {
    [TestMethod]
    public void ShouldReturnAllCompletedAndUncompletedTodosWhenNotSpecified()
    {
      var todoService = new TodoServiceMock();
      var todoController = new TodoController(todoService);

      var listTodosTask = todoController.List();
      var todos = listTodosTask.Result;

      var containsCompletedTodos = todos.Any(todo => todo.Completed);
      var containsUncompletedTodos = todos.Any(todo => !todo.Completed);

      Assert.IsTrue(containsCompletedTodos && containsUncompletedTodos);
    }

    [TestMethod]
    public void ShouldReturnOnlyCompletedTodosWhenSpecified()
    {
      var todoService = new TodoServiceMock();
      var todoController = new TodoController(todoService);

      var listTodosTask = todoController.ListCompleted();
      var todos = listTodosTask.Result;

      var containsUncompletedTodos = todos.Any(todo => !todo.Completed);

      Assert.IsFalse(containsUncompletedTodos);
    }

    [TestMethod]
    public void ShouldReturnOnlyUncompletedTodosWhenSpecified()
    {
      var todoService = new TodoServiceMock();
      var todoController = new TodoController(todoService);

      var listTodosTask = todoController.ListUncompleted();
      var todos = listTodosTask.Result;

      var containsCompletedTodos = todos.Any(todo => todo.Completed);

      Assert.IsFalse(containsCompletedTodos);
    }
  }
}
