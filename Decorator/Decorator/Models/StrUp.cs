using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Models
{
    class StrUp : LevelUp
    {
        public StrUp(ICharacter @char) : base(@char)
        {
        }

        public override string GetPath()
        {
            return base.GetPath() + " took steroids,";
        }

        public override int GetStrength()
        {
            return base.GetStrength() + 2;
        }

       
    }
}
