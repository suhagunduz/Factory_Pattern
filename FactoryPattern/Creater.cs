using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Creater
    {
        public AbstractFactoryCars FactoryMethod(AllCars CarType)
        {
            AbstractFactoryCars abstractFactoryCars = null;
            switch (CarType)
            {
                case AllCars.Sedan:
                    abstractFactoryCars = new Sedan();
                    break;
                case AllCars.Hatchback:
                    abstractFactoryCars = new Hatchback();
                    break;
                case AllCars.StationWagon:
                    abstractFactoryCars = new StationWagon();
                    break;
                case AllCars.Suv:
                    abstractFactoryCars = new Suv();
                    break;
                case AllCars.PicUp:
                    abstractFactoryCars = new PicUp();
                    break;
            }
            return abstractFactoryCars;
        }
    }
}
