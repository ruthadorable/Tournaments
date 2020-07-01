using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary1.Models;

namespace TrackerLibrary1.DataAccess
{
    class TextConnector : IDataConnection, IDisposable
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
