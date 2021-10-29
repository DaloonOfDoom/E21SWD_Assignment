using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Models
{
    class Orc : ICharacter
    {
        public string GetPath()
        {
            return $"This Orc";
        }

        public int GetStrength()
        {
            return 7;
        }

        public int GetDexterity()
        {
            return 5;
        }

        public int GetIntelligence()
        {
            return 3;
        }

        public int GetLevel()
        {
            return 1;
        }
    }
}
