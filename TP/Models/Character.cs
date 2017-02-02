using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.Models
{
    public class Character
    {
        public string Name { get; set; }
        public Uri Image { get; set; }
        public string Race { get; set; }
        public string Description { get; set; }
        public Uri ImageTransfo { get; set; }
        public Character(string name, Uri image, string race, string description, Uri image2 )
        {
            Name = name;
            Image = image;
            Race = race;
            Description = description;
            ImageTransfo = image2;
            

        }
    }
}
