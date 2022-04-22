using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Smartphone
    {
        public string ProcessorType { get; set; }
        public string ScreenType { get; set; }
        public string InternalStorage { get; set; }
        public string RAM { get; set; }
        public List<string> Camera { get; set; }
        public Smartphone()
        {
            Camera = new List<string>();
        }
        public string ManifactureDate { get; set; }

    }
}
