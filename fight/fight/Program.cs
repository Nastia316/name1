using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace inherit_class
{
    public abstract class Character
    {
        public string Name;
        public int Health;

        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }
        public abstract int Attack();
        public abstract int Attack2();

        public void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health < 0) Health = 0;
        }
        public bool IsAlive => Health > 0;

    }

    public class Mage : Character
    {
        public Mage(string name) : base(name, 100) { }
        public override int Attack()
        {
            Console.WriteLine($"{Name} кастует заклинание огня");
            int a = new Random().Next(1, 10);
            if (a > 9)
            {
                return 30;
            }
            else if (a > 4)
            {
                return 18;
            }
            else
            {
                return 0;
            }
        }
        public override int Attack2()
        {
            Console.WriteLine($"{Name} кастует заклинание воды");
            int a = new Random().Next(1, 20);
            if (a > 17)
            {
                return 25;
            }
            else if (a > 10)
            {
                return 20;
            }
            else
            {
                return 0;
            }
        }
    }

    public class Warrior : Character
    {
        public Warrior(string name) : base(name, 120) { }
        public override int Attack()
        {
            Console.WriteLine($"{Name} бьет кулаком");
            return new Random().Next(10, 20);
        }
        public override int Attack2()
        {
            Console.WriteLine($"{Name} бьет дубиной");
            int a = new Random().Next(1, 20);
            if (a > 17)
            {
                return 25;
            }
            else if (a > 7)
            {
                return 20;
            }
            else
            {
                return 0;
            }
        }
    }
    public class Archer : Character
    {
        public Archer(string name) : base(name, 110) { }
        public override int Attack()
        {
            Console.WriteLine($"{Name} стреляет из лука");
            return new Random().Next(10, 20);
        }
        public override int Attack2()
        {
            Console.WriteLine($"{Name} выпускает зачарованную стрелу");
            if (new Random().Next(1, 10) > 3)
            {
                return 18;
            }
            else
            {
                return 0;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите класс - 1-маг, 2-воин, 3-лучник");
            string choice = Console.ReadLine();
            Character player;
            switch (choice)
            {
                case "1":
                    player = new Mage("Игрок");
                    Console.WriteLine("Вы-маг. На цифру 1 вы сможете запустить огненный шар, на цифру 2-водный шторм");
                    break;
                case "2":
                    player = new Warrior("Игрок");
                    Console.WriteLine("Вы-воин. На цифру 1 вы сможете ударить врага кулаком, на цифру 2-дубиной");
                    break;
                case "3":
                    player = new Archer("Игрок");
                    Console.WriteLine("Вы-лучник. На цифру 1 вы сможете запустить обычную стрелу, на цифру 2-зачарованную");
                    break;
                default:
                    Console.WriteLine("Неправильный выбор, по умолчанию вы воин. На цифру 1 вы сможете ударить врага кулаком, на цифру 2-дубиной");
                    player = new Warrior("Игрок");
                    break;
            }
            Console.WriteLine("На цифру 3 вы сможете поставить блок");
            Console.WriteLine("На цифру 4 ОДИН раз за игру вы сможете выпить зелье, восстанавливающее 20 единиц здоровья");
            int zel = 1;
            int a = new Random().Next(1, 3);
            Character enemy;
            switch (a)
            {
                case 1:
                    enemy = new Mage("Злой маг");
                    break;
                case 2:
                    enemy = new Warrior("Огр");
                    break;
                case 3:
                    enemy = new Archer("Скелет");
                    break;
                default:
                    enemy = new Warrior("Огр");
                    break;
            }
            Console.WriteLine($"Бой начинается! {player.Name} против {enemy.Name}");
            while (player.IsAlive && enemy.IsAlive)
            {
                Console.WriteLine("\nВаш ход");
                Console.WriteLine("\nВыберите тип атаки, блок или зелье (1, 2, 3 или 4):");
                string choice2 = Console.ReadLine();
                int damage;
                int block = 0;
                switch (choice2)
                {
                    case "1":
                        damage = player.Attack();
                        break;
                    case "2":
                        damage = player.Attack2();
                        break;
                    case "3":
                        damage = 0;
                        block = 1;
                        break;
                    case "4":
                        if (zel == 1)
                        {
                            damage = 0;
                            zel = 0;
                            player.Health += 20;
                            Console.WriteLine($"Вы выпили зелье. Ваше здоровье: {player.Health}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Вы больше не можете выпить зелье, тк оно закончилось.");
                            damage = player.Attack();
                            break;
                        }
                    default:
                        damage = player.Attack();
                        break;
                }
                enemy.TakeDamage(damage);
                Console.WriteLine($"Враг получил {damage} единиц урона. Здоровье врага: {enemy.Health}");

                if (!enemy.IsAlive)
                {
                    Console.WriteLine("Вы победили!");
                    break;
                }

                Console.WriteLine("\nХод врага");
                if (block==0)
                {
                    int enemyDamage = enemy.Attack();
                    player.TakeDamage(enemyDamage);
                    Console.WriteLine($"Вы получили {enemyDamage} единиц урона. Ваше здоровье: {player.Health}");
                }
                else
                {
                    int enemyDamage = 0;
                    player.TakeDamage(enemyDamage);
                    Console.WriteLine($"Вы получили {enemyDamage} единиц урона. Ваше здоровье: {player.Health}");
                }

                if (!player.IsAlive)
                {
                    Console.WriteLine("Вы проиграли!");
                    break;
                }

            }
            Console.WriteLine("Конец боя");
        }
    }
}