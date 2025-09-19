using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Game.Skills;

namespace The_Game.Tests
{
    public class SkillTests
    {
        [Fact]
        public void Skills_Is_Basic()
        {
            var skill1 = new ActiveSkill("Skill One", true);
            var skill2 = new ActiveSkill("Skill Two", false);

            Assert.True(skill1.IsBasic);
            Assert.False(skill2.IsBasic);
        }

        [Fact]
        public void Skill_Is_Cloned()
        {
            var skill = SkillDatabase.CloneSkill(SkillDatabase.Fire);

            var elementName = "Fire Attack";
            var element = Elements.ElementTypes.Fire;
            
            Assert.Equal(skill.Element, element);
            Assert.Equal(skill.Name, elementName);
        }
    }
}
