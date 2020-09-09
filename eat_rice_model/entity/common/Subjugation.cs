using eat_rice_model.entity.homeworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eat_rice_model.entity.common
{
    public class Subjugation : DayHomework
    {
        private int _Key;

        private int _Tire;

        public int Tire { get => _Tire; set => _Tire = value; }
        public int Key { get => _Key; set => _Key = value; }
    }
}
