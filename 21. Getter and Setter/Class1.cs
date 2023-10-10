using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Getter_and_Setter
{
    internal class movie
    {
        public string Title;
        public string Director;
        private string rating;

        public movie(string aTitle, string aDirector, string aRating)
        {
            Title = aTitle;
            Director = aDirector;
            Rating = aRating;
        }

        public string Rating
        {
            get { return Rating; }

            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                {
                    Rating = value;

                }
                else
                {
                    Rating = "NR";
                }
            }
        }
    }
}
            
        
            
        

   

                
  
        
              

        
                


