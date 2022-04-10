using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.WebUI.Models
{
    public class Recipe : IDisposable
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string time { get; set; }
        public string difficulty { get; set; }
        public string ingredients { get; set; }
        public string tipsAndTricks { get; set; }
        public int numberOfLikes { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
