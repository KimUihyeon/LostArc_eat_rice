using eat_rice_model.entity.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eat_rice_model.entity.homeworks
{
    public abstract class Homework
    {
        private string _Name;
        private bool _IsComplate;
        private string _Etc;
        private List<Itme> _Rewards;

        public string Etc { get => _Etc; set => _Etc = value; }
        public bool IsComplate { get => _IsComplate; set => _IsComplate = value; }
        public string Name { get => _Name; set => _Name = value; }
        public List<Itme> Rewards { get => _Rewards; set => _Rewards = value; }
    }
}
