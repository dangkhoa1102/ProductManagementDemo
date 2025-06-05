using System.Collections.Generic;
using BusinessObjects;
using DataAccessObjects;

namespace Repositories
{
    public class CategoryRepository : ICatergoryRepository
    {
        public List<Category> GetCategories() => CategoryDAO.GetCategories();    
    }
}

