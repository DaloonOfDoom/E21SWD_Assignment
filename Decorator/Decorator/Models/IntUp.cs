using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Models
{
    class IntUp : LevelUp
    {
        public IntUp(ICharacter @char) : base(@char)
        {
        }

        public override string GetPath()
        {
            return base.GetPath() + " got more smarter,";
        }

        public override int GetIntelligence()
        {
            return base.GetIntelligence() + 1;
        }

       
    }
}
