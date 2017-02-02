using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.Models
{
    public class Character
    {
        public string Name { get; private set; }
        public Uri Image { get; private set; }

        public Character(string name, Uri image )
        {
            Name = name;
            Image = image;
        }
    }
}
