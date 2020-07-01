using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TrackerLibrary1.Models;
using System.Data;
using Dapper;

namespace TrackerLibrary1.DataAccess
{
    public class SqlConnector : IDataConnection
    {   /// TODO - Make the CreatePrize method actually save the database
        /// <summary>
        /// Saves a prize to the database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information,including the unique unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            }
        }
    }
}
