using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakteacheskaya
{
    public enum MeasureUnits
    {
        Slave,
        GigaNigga,
        BoyNextDoor
    }

    internal class Human
    {
        private int _age;
        private MeasureUnits _measureUnit = MeasureUnits.Slave;
        private Man _man;

        public int Age
        {
            get => _age;
        }

        public MeasureUnits MeasureUnit
        {
            get => _measureUnit;
        }

        private Man Man
        {
            get => _man;
        }

        public string ManName
        {
            get { return Man != null ? Man.Name : "Не назначено"; }
        }

        public Human(int age, MeasureUnits measureUnit, Man man)
        {
            _age = age;
            _measureUnit = measureUnit;
            _man = man;
        }


    }
}
