using System;

namespace OOPSuperHeros
{
    class Program
    {
        class Player
        {
            string name;
            int hp;

            public Player(string _name)
            {
                name = _name;
                Random rnd = new Random();
                hp = rnd.Next(100, 151);
            }

            public void SayHello()
            {
                Console.WriteLine($"{name} says hello");
            }

            public void ShowYourHP()
            {
                Console.WriteLine($"{name}'s HP: {hp}");
            }

            public int MakeDamage()
            {
                Random rnd = new Random();
                return rnd.Next(10, 51);
            }


            public void TakeDamage(int damage)
            {
                if (hp <= 0)
                {
                    hp = 0;
                }
                else
                {
                    hp = hp - damage;
                }
            }

            public int HP
            {
                get { return hp; }
            }

            public string Name { 
                get {return name; }
            }
        }

         static void Main(string[] args)
        {
            Console.WriteLine("Name your character");
            string characterNameOne = Console.ReadLine();
            Console.WriteLine("Name your second character");
            string characterNameTwo = Console.ReadLine();



            Player PlayerOne = new Player(characterNameOne);
            Player PlayerTwo = new Player(characterNameTwo);
            PlayerOne.SayHello();
            PlayerOne.ShowYourHP();
            PlayerTwo.SayHello();
            PlayerTwo.ShowYourHP();

            for(int i = 0; i < 3; i++)
            {
                PlayerOne.TakeDamage(PlayerTwo.MakeDamage());
                PlayerTwo.TakeDamage(PlayerOne.MakeDamage());
                PlayerOne.ShowYourHP();
                PlayerTwo.ShowYourHP();
            }
            if(PlayerOne.HP > PlayerTwo.HP)
            {
                Console.WriteLine("player one won");
            }else if (PlayerOne.HP < PlayerTwo.HP)
            {
                Console.WriteLine("Player Two won");
            }else
            {
                Console.WriteLine("it's a tie");
            }

        }
    }
}
