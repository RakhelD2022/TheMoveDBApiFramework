using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDBAPITesting
{
    public class DataValidationMethods
    {
        public class GuestStars
        {
            public string character { get; set; }
            public string name { get; set; }
        }

        public class Episodes
        {
            public GuestStars GuestStars { get; set; }
            public string SeasonNumber { get; set; }
        }

        var data = JsonConvert.DeserializeObject<RootObject>(myJSON);
        nameArticles=data.articles.FirstOrDefault().description;
        MessageBox.Show(nameArticles);
    }
}
