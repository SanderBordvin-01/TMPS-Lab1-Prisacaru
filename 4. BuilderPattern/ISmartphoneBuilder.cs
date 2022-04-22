using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface ISmartphoneBuilder
    {
        public ISmartphoneBuilder SetProcessorType(string _processorType);
        public ISmartphoneBuilder SetScreenType(string _screenType);

        public ISmartphoneBuilder SetInternalStorage(string _internalStorage);

        public ISmartphoneBuilder SetRAM(string _ram);

        public ISmartphoneBuilder SetCamera(string _camera);
        public ISmartphoneBuilder SetManifactureDate(DateTime _date);
        public void ShowInfo();
    }
}
