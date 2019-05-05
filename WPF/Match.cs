using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }

        public string Team1 { get; set; }
        public string Team2 { get; set; }

        public int Completion { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}:{2} {3}", Team1, Score1, Score2, Team2);
        }
    }
}
