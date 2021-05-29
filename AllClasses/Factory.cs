using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.AllClasses
{
    class Factory
    {

       

        public  static Punter GetAPunter(int id)
        {
            switch (id)
            {
                case 0:
                    return new Prabneet();
                case 1:
                    return new Rahul();
                case 2:
                    return new Akash();

                default: return null;


            }

        }

        public Punter get(int v)
        {
            switch (v)
            {
                case 0:
                    return new Prabneet();
                case 1:
                    return new Rahul();
                case 2:
                    return new Akash();

                default: return null;


            }
        }
    }
}
