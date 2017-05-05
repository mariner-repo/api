using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariner.DOMAIN.GaiaCORE
{
    public class ResultWatson
    {
        public string custom_classes { get; set; }
        public List<Images> images { get; set; }

        public class Images
        {
            public List<Classifiers> classifiers { get; set; }

            public class Classifiers
            {
                public List<Classes> classes { get; set; }
                public string classifier_id { get; set; }

                public string name { get; set; }

                public class Classes
                {
                    public string @class { get; set; }
                    public float score { get; set; }
                }

            }
        }
    }
}
