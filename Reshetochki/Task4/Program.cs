using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For 1:check another project\n\n" +
                              "Choose: 2: Flag\n" +
                              "        3: Virtual_and_IDontLikeThisComands\n");
          int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 2:
                    Console.WriteLine("Oh no, we have no this solution(");
                    break;
                case 3:
                    IDontLikeFunc();
                    break;
                default:
                    Console.WriteLine("try again");
                    break;

            }
        }
         public static void IDontLikeFunc()
        {
            Console.WriteLine("I dont have any unloved teams. Maybe you have?\n Yes or 1/No or 2");
            string command = Console.ReadLine();
            command = command.ToUpper();
            IDontLike team = new IDontLike();

            if ((command == "YES") || (command == "1"))
            {
                Console.WriteLine("Soo, choose the team name, hater\n1: Akcio\n2: Ezji\n3: Reticolo\n4: Sherpei\n5: Reshetochki");
                int sel = int.Parse(Console.ReadLine());
                switch (sel)
                {
                    case 1:
                        team.name = "Akcio";
                        Console.WriteLine("Good choice\n");
                        break;
                    case 2:
                        team.name = "Ezji";
                        Console.WriteLine("Good choice\n");
                        break;
                    case 3:
                        team.name = "Reticolo";
                        Console.WriteLine("Good choice\n");
                        break;
                    case 4:
                        team.name = "Sharpei";
                        Console.WriteLine("Good choice\n");
                        break;
                    case 5:
                        team.name = "Resheochki";
                        Console.WriteLine("Oh noo(((");
                        break;
                    default:
                        Console.WriteLine("Okey, just nobody");
                        team.name = "Nobody";
                        break;
                }

            }
            if ((command == "NO") || (command == "2"))
            {
                Console.WriteLine("Hmmmmm, okey\n");
                team.name = "Nobody";
            }
            object ThisTeam = new IDontLike() { name = "Nobody" };

            Console.WriteLine($"ToString:  {team.ToString()} \n");

            Console.Write("Equals: ");
            if (team.Equals(ThisTeam)) Console.WriteLine("Ohhhh, nice. You love everyone, because you chose 2 higher\n");
            else Console.WriteLine("Hater\n");

            Console.WriteLine(team.GetHashCode());
            Console.ReadKey();
        }
    }
}
