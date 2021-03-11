using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;
using GameProject.Abstract;


namespace GameProject.Adapter
{
    class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            /* KPSPublicSoapClient client = new KPSPublicSoapClient();
               return client.TCKimlikNoDogrula(Convert.ToInt64(player.NationalityId), player.FirstName.ToUpper(),
                player.LastName.ToUpper(), player.DateOfBirth.Year);
            */
            return true;
        }
    }
}
