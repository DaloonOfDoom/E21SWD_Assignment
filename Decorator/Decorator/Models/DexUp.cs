using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Models
{
    class DexUp : LevelUp
    {
        public DexUp(ICharacter @char) : base(@char)
        {
        }

        public override string GetPath()
        {
            return base.GetPath() + " went for a run,";
        }

        public override int GetDexterity()
        {
            return base.GetDexterity() + 2;
        }
    }

}
