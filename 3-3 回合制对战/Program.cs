using System;
using System.Collections.Generic;

namespace _3_3_回合制对战
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Character player = new Character("三尾狐",875,124,68,1000);
            Skill skill = new Skill("尾袭", SkillType.NormalAttack,10000);
            player.AddSkill(skill);

            Character enemy = new Character("雨女", 1035, 97, 73, 500);
            Skill eskill = new Skill("泪珠", SkillType.NormalAttack, 10000);
            enemy.AddSkill(eskill);

            int round = 1;

            while (true)
            {
                Console.WriteLine($"------第{round}回合------");

                // 玩家攻击敌人
                // 选择技能
                Skill playerSkill = player.skills[0];
                player.Attack(playerSkill, enemy);
                // 判断敌人是否死亡
                if(enemy.IsDead())
                { Console.WriteLine($"{enemy.name}战败了！"); break; }


                Skill enemySkill = enemy.skills[0];
                enemy.Attack(enemySkill, player);
                if (player.IsDead())
                { Console.WriteLine($"{player.name}战败了！"); break; }
            }

            if (player.IsDead())
            { Console.WriteLine($"{player.name}战败了，游戏结束。"); }
            else
            { Console.WriteLine($"恭喜{player.name}获得胜利！"); }

            Console.ReadKey();
        }
    }
}
