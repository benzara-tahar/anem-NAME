using System.Collections.Generic;

namespace Anem.NAME.Models
{
    public class FicheNameDetails : Item
    {
        public string Definition { get; set; }
        public IList<Item> AppelationDetails { get; set; }
        public IList<Item> ConditionExerciceDetails { get; set; }
        public IList<Item> ConditionAccessDetails { get; set; }
        public IList<Item> LieuTravailDetails { get; set; }
        public IList<Item> ActiviteBaseDetails { get; set; }
        public IList<Item> CompetenceBaseDetails { get; set; }
        public IList<ActiviteSpecifique> ActiviteSpecifiqueDetails { get; set; }
        public FicheNameDetails()
        {

            AppelationDetails = new List<Item>();
            ConditionExerciceDetails = new List<Item>();
            ConditionAccessDetails = new List<Item>();
            LieuTravailDetails = new List<Item>();
            ActiviteBaseDetails = new List<Item>();
            CompetenceBaseDetails = new List<Item>();
            ActiviteSpecifiqueDetails = new List<ActiviteSpecifique>();

        }

    }


}
