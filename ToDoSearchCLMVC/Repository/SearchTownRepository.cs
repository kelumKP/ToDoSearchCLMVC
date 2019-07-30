using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ToDoSearchCLMVC.Models;

namespace ToDoSearchCLMVC.Repository
{
    public class SearchTownRepository   : ISearchTownRepository
    {
        TodoListDBEntities context = new TodoListDBEntities();
        public object SearchTown(string term)
        {
            var town = from p in context.ToDoListTables
                       where p.Name.ToLower().StartsWith(term.ToLower())
                       select new { Id = p.Id, Name = p.Name };

            return town;
        }
    }
}