using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IronForge.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, Name="Barbells"},
                new Category{CategoryId=2, Name="Plates"},
                new Category{CategoryId=3, Name="Benches"},
                new Category{CategoryId=4, Name="Racks"}

            };
    }
}
