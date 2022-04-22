using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        public static void BuildSamsungPhone(ISmartphoneBuilder builder)
        {
            builder
                .SetProcessorType("SnapDragon625")
                .SetScreenType("Glass")
                .SetInternalStorage("128GB")
                .SetRAM("8GB")
                .SetCamera("48MP")
                .SetCamera("12MP")
                .SetCamera("8MP")
                .SetManifactureDate(DateTime.UtcNow);
        }
        static void Main(string[] args)
        {
            SamsungBuilder builder = new SamsungBuilder();
            BuildSamsungPhone(builder);
            builder.Build();
            builder.ShowInfo();
        }
    }
}