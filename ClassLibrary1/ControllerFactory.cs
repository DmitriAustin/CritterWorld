using CritterController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMarket
{
    class ControllerFactory : ICritterControllerFactory
    {
        public string Author => "100495583";

        public ICritterController[] GetCritterControllers()
        {
            List<ICritterController> controllers = new List<ICritterController>();
            for (int i = 0; i < 25; i++)
            {
                controllers.Add(new DepressedFarmer("DepressedFarmer" + (i + 1)));
                controllers.Add(new HappyButcher("HappyButcher" + (i + 1)));
            }
            return controllers.ToArray();
        }
    }
}
