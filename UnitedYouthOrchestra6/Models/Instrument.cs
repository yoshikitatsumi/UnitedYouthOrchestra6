using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitedYouthOrchestra6.Models
{
    public class Instrument
    {
        public int Id { get; set; }
        public bool Violin { get;set; }
        public bool Viola { get; set; }
        public bool Cello { get; set; }
        public bool DoubleBass { get; set; }
        public bool Flute { get; set; }
        public bool Oboe { get; set; }
        public bool Clarinet { get; set; }
        public bool Bassoon { get; set; }
        public bool Horn { get; set; }
        public bool Trumpet { get; set; }
        public bool Trombone { get; set; }
        public bool Tuba { get; set; }
        public bool TimpaniPerc { get; set; }
        public bool Keyboard { get; set; }
    }
}
