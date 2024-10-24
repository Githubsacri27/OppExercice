using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    public class Grandfather
    {

        public string Name { get; set; }
        protected int Age { get; set; }
        private string FavoriteColor { get; set; }

        public Grandfather(string name, int age, string favoriteColor)
        {
            Name = name;
            Age = age;
            FavoriteColor = favoriteColor;
        }

        public string GetFavoriteColor() => FavoriteColor;
        public void SetFavoriteColor(string value) => FavoriteColor = value;
    }

}
