using System;
using System.Collections.Generic;
using System.Text;

namespace Hw29
{
    public class HDD : Storage
    {
        private double SpeedOfUSB20 { get; set; }
        private int SectionAmount { get; set; }
        private double SizeOfSection { get; set; }
    }
}
