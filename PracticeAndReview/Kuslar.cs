using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview
{
    internal class Kuslar
    {
        public string tur;
        //public string ses;
        public int hiz;
        public double agirlik;

        public virtual string SesCikar()
        {
            return "buraya ses yazilacak";
        }
    }
}
