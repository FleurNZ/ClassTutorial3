using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery3Selfhost
{
    class Service1:IService1
    {

        public List<String> GetArtistNames()
        {
            using(Gallery_DataEntities lcContent = new Gallery_DataEntities())
            {
                return lcContent.Artists.Select(lcArtist => lcArtist.Name).ToList();
            }
        }

    }
}
