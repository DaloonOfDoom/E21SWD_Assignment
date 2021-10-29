using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Models
{
    class Human : ICharacter
    {
        public string GetPath()
        {
            return $"This Human";
        }

        public int GetStrength()
        {
            return 3;
        }

        public int GetDexterity()
        {
            return 5;
        }

        public int GetIntelligence()
        {
            return 7;
        }

        public int GetLevel()
        {
            return 1;
        }
    }
}
