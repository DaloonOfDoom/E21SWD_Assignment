using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Models
{
    public abstract class LevelUp : ICharacter
    {
        private ICharacter base_;

        protected LevelUp(ICharacter @char)
        {
            base_ = @char;
        }

        public virtual string GetPath()
        {
            return base_.GetPath();
        }

        public virtual int GetStrength()
        {
            return base_.GetStrength();
        }

        public virtual int GetDexterity()
        {
            return base_.GetDexterity();
        }


        public virtual int GetIntelligence()
        {
            return base_.GetIntelligence();
        }

    }
}
