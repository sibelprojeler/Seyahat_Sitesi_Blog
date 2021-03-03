using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SeyahatSitesi.Models.Siniflar;

namespace SeyahatSitesi.Models.Entity

{
    public class BlogYorum
    { public IEnumerable<Blog> Deger1 { get; set; }
      public IEnumerable <Yorumlar> Deger2 { get; set; }
      public IEnumerable<Blog> Deger3 { get; set; }
      public IEnumerable<Yorumlar> Deger4 { get; set; }
      public IEnumerable<Yorumlar> Deger5 { get; set; }
    }
}