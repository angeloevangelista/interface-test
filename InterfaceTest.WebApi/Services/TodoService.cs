using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using InterfaceTest.WebApi.Entities;
using InterfaceTest.WebApi.Interfaces;
using Newtonsoft.Json;

namespace InterfaceTest.WebApi.Services
{
  public class TodoService: ITodoService
  {
    private readonly HttpClient _httpClient;

    public TodoService(HttpClient httpClient)
    {
      this._httpClient = httpClient;
      
      this._httpClient.BaseAddress = new Uri(
        "https://jsonplaceholder.typicode.com"
      );
    }

    public async Task<List<Todo>> ListAllTodos()
    {


      var response = await this._httpClient.GetAsync("todos");
      var responseBody = await response.Content.ReadAsStringAsync();

      List<Todo> todos = JsonConvert.DeserializeObject<List<Todo>>(responseBody);

      return todos;
    }
  }
}