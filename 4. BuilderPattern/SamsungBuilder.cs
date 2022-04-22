using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class SamsungBuilder : ISmartphoneBuilder
    {
        private readonly Smartphone _smartPhone = new Smartphone();
        public string _Name;
        public SamsungBuilder()
        {
            Console.Write("Enter Samsung Model : ");
            _Name = Console.ReadLine();
        }
        public ISmartphoneBuilder SetCamera(string _camera)
        {
            _smartPhone.Camera.Add(_camera);
            return this;
        }

        public ISmartphoneBuilder SetInternalStorage(string _internalStorage)
        {
            _smartPhone.InternalStorage = _internalStorage;
            return this;
        }

        public ISmartphoneBuilder SetManifactureDate(DateTime _date)
        {
            _smartPhone.ManifactureDate = _date.ToString("dd/MM/yyyy");
            return this;
        }

        public ISmartphoneBuilder SetProcessorType(string _processorType)
        {
            _smartPhone.ProcessorType = _processorType;
            return this;
        }

        public ISmartphoneBuilder SetRAM(string _ram)
        {
            _smartPhone.RAM = _ram;
            return this;
        }

        public ISmartphoneBuilder SetScreenType(string _screenType)
        {
            _smartPhone.ScreenType = _screenType;
            return this;
        }

        public Smartphone Build()
        {
            return _smartPhone;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Model : " + _Name);
            Console.WriteLine("Processor : " + _smartPhone.ProcessorType);
            Console.WriteLine("Screen : " + _smartPhone.ScreenType);
            Console.WriteLine("Internal Storage : " + _smartPhone.InternalStorage);
            Console.WriteLine("RAM : " + _smartPhone.RAM);
            Console.Write("Camera's : ");
            _smartPhone.Camera.ForEach(x => Console.Write("{0} ", x));
            Console.WriteLine();
            Console.WriteLine("Manifacture Date : " + _smartPhone.ManifactureDate);
        }
    }
}
