using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace Scheduler
{
    [DelimitedRecord(",")]
    [IgnoreFirst(1)]
    public class Station
    {
        public string Name { get; set; }
        [FieldConverter(ConverterKind.Boolean, "TRUE", "FALSE")]
        public bool Line1 { get; set; }
        [FieldConverter(ConverterKind.Boolean, "TRUE", "FALSE")]
        public bool Line2 { get; set; }
        [FieldConverter(ConverterKind.Boolean, "TRUE", "FALSE")]
        public bool Line3 { get; set; }
        [FieldConverter(ConverterKind.Boolean, "TRUE", "FALSE")]
        public bool Line4 { get; set; }
    }
}
