using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Models
{
    public abstract class LevelUp : ICharacter
    {
        private readonly ICharacter _base;

        protected LevelUp(ICharacter @char)
        {
            _base = @char;
        }

        public virtual string GetPath()
        {
            return _base.GetPath();
        }

        public virtual int GetStrength()
        {
            return _base.GetStrength();
        }

        public virtual int GetDexterity()
        {
            return _base.GetDexterity();
        }


        public virtual int GetIntelligence()
        {
            return _base.GetIntelligence();
        }

        public virtual int GetLevel()
        {
            return _base.GetLevel() +1;
        }
    }
}
