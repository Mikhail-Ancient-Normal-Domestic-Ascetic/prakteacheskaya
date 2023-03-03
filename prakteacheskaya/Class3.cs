using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace prakteacheskaya
{
    public class BoysDatabase
    {
        private Random _random = new Random();
        private int RandomAge
        {
            get => _random.Next(12, 28);
        }
        internal List<Human> Weathers { get; private set; }

        public void Initialize()
        {
            Weathers = new List<Human>
            {
                new Human(RandomAge, MeasureUnits.Slave, new Man("Джонни")),
                new Human(RandomAge, MeasureUnits.GigaNigga, new Man("Билли")),
                new Human(RandomAge, MeasureUnits.BoyNextDoor, new Man("Бобби")),
                new Human(RandomAge, MeasureUnits.GigaNigga, new Man("Вэн")),
                new Human(RandomAge, MeasureUnits.Slave, new Man("Питер")),
                new Human(RandomAge, MeasureUnits.Slave, new Man("Ричард")),
                new Human(RandomAge, MeasureUnits.GigaNigga, new Man("Адриано")),
                new Human(RandomAge, MeasureUnits.Slave, new Man("Азамат")),
                new Human(RandomAge, MeasureUnits.Slave, new Man("Рыбачок"))
            };
        }
    }
}
