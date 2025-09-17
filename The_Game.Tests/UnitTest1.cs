using Xunit;
using The_Game.character;
using The_Game.Skills;
using The_Game.monsters;

namespace The_Game.Tests
{
    public class CharacterTests
    {
        [Fact]
        public void Character_Should_Have_Default_Attack_Skill()
        {
            var hero = new TestCharacter("Hero", 100, 1, 0, 0);

            Assert.NotNull(hero.combatSkills);
            Assert.True(hero.combatSkills.Length > 0);
            Assert.Equal("Attack", hero.combatSkills[0].Name);
        }

        [Fact]
        public void Attack_Should_Reduce_Target_Health()
        {
            var hero = new TestCharacter("Hero", 100, 1, 0, 0);
            var monster = new SmallMonster("Monster", 1);

            int before = monster.Health;
            //Console.WriteLine(before);

            hero.Attack(monster);
            //Console.WriteLine(monster.Health);

            Assert.True(monster.Health < before, "Monster should lose health after attack.");
        }

        [Fact]
        public void GainExperience_Should_Level_Up_When_Enough_XP()
        {
            var hero = new TestCharacter("Hero", 100, 1, 0, 0);

            hero.GainExperience(200); // ToLevel = 100, should level up

            Assert.Equal(2, hero.Level);
            Assert.True(hero.Experience >= 200);
        }

        [Fact]
        public void CombatSkills_Should_Expand_On_LevelThreshold()
        {
            var hero = new TestCharacter("Hero", 100, 4, 0, 0);
            Assert.Single(hero.combatSkills); // only Attack

            hero.GenCombatSkillList(5); // Hit a threshold
            Assert.Equal(2, hero.combatSkills.Length);
        }


    }

    // A simple testable subclass (since CharacterBase is abstract)
    public class TestCharacter : CharacterBase
    {
        public TestCharacter(string name, int maxHealth, int level, int experience, int coins)
            : base(name, maxHealth, level, experience, coins) { }

        public override void EarnCoins(int amount) { }
        public override void AttributeGainXP(CharacterBase user, SkillBase skill, int exp) { }
        public override void TakeDamage(int amount, CharacterBase target) { }
        public override void OnDeath(CharacterBase target) { }
    }






}

