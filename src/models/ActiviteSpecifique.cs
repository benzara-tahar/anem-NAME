using System.Collections.Generic;

namespace Anem.NAME.Models
{
    public class ActiviteSpecifique : Item
    {
        public IList<Item> CompetenceSpecifiqueDetails { get; set; }

        public ActiviteSpecifique()
        {
            CompetenceSpecifiqueDetails = new List<Item>();
        }

    }


}
