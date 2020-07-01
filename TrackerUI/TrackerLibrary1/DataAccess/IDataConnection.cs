using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary1.Models;

namespace TrackerLibrary1.DataAccess

{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);


    }
}
