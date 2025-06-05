using BusinessObjects;
using System.Collections.Generic;

namespace Services
{
    public interface ICatergoryService
    {
        List<Category> GetCategories();
    }
}
