using System.Collections.Generic;

namespace Anem.NAME.Models
{
    public class NameObject
    {
        public string Id { get; set; }
        public int Level { get; set; }
        public string Intitule { get; set; }
        public IList<NameObject> NameObjects { get; set; }
        public NameObject()
        {
            NameObjects = new List<NameObject>();
        }

    }


}
