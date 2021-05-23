using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaShop.Data.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDegault { get; set; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }
        public List<ProductTranslation> ProductTranslations { get; set; }
    }
}
