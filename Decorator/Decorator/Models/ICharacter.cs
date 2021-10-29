using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Models
{
    public interface ICharacter
    {
        public string GetPath();
        public int GetStrength();
        public int GetDexterity();
        public int GetIntelligence();

    }
}
