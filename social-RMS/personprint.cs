using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace social_RMS
{
   public class personprint
    {
        public int id { get; set; }
        public string name_fr { get; set; }
        public string name_ar { get; set; }
        public string cne { get; set; }
        public int validateterrain { get; set; }
        public int validateEnregiter { get; set; }
        public int validateLicence { get; set; }
        private string _id_versement;
        public string id_versement
        {
            get
            {
                return _id_versement;
            }
            set
            {
                
                if (value == "3")
                {
                    _id_versement = "achat de terrain :";
                }
                else if (value == "4")
                {
                    _id_versement = "Enregistrement : ";
                }
                else if (value == "5")
                {
                    _id_versement = "autorisation : ";

                }
                
            }




        }

        public int sum_group_price { get; set; }
        




    }
}
