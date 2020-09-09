using eat_rice_model.entity.enums;
using eat_rice_model.entity.homeworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eat_rice_model.entity
{
    public class Actor
    {
        private string _Name;
        private ActorClass _ActorClass;

        private List<DayHomework> _DayHomeworks;
        private List<WeekHomework> _WeekHomeworks;


        public string Name { get => _Name; set => _Name = value; }
        public ActorClass ActorClass { get => _ActorClass; set => _ActorClass = value; }

        public List<DayHomework> DayHomeworks { get => _DayHomeworks; set => _DayHomeworks = value; }
        public List<WeekHomework> WeekHomeworks { get => _WeekHomeworks; set => _WeekHomeworks = value; }

        private Actor()
        {

        }

        public static Actor Create()
        {
            Actor actor = new Actor();
            actor.DayHomeworks = new List<DayHomework>();
            actor.WeekHomeworks = new List<WeekHomework>();
            actor.ActorClass = ActorClass.NONE;

            return actor;
        }
    }
}

