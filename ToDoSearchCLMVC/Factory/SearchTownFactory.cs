using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoSearchCLMVC.Repository;

namespace ToDoSearchCLMVC.Factory
{
    public class SearchTownFactory
    {
        public object SearchTown(string term)
        {
            SearchTownRepository searchTownRepo = new SearchTownRepository();

            var town = searchTownRepo.SearchTown(term);

            return town;
        }
    }
}