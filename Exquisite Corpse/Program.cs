using System;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Random or Manual.");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "random")
            {
                RandomMode();
            }
            else if (choice.ToLower() == "manual")
            {
                Console.WriteLine("Type ghost, monster, or bug for the head piece.");
                string head = Console.ReadLine();
                Console.WriteLine("Type ghost, monster, or bug for the body piece.");
                string body = Console.ReadLine();
                Console.WriteLine("Type ghost, monster, or bug for the feet piece.");
                string feet = Console.ReadLine();

                BuildACreature(head.ToLower(), body.ToLower(), feet.ToLower());
            }
            else
            {
                Console.WriteLine("You didn't type Random or Manual.");
            }
        }
        static void BuildACreature(string head, string body, string feet)
        {
            int headNum = TranslateToNumber(head);
            int bodyNum = TranslateToNumber(body);
            int feetNum = TranslateToNumber(feet);
            SwitchCase(headNum, bodyNum, feetNum);
            return;
        }
        static void RandomMode()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 3);
            int body = randomNumber.Next(1, 3);
            int feet = randomNumber.Next(1, 3);
            SwitchCase(head, body, feet);
        }
        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                case 3:
                    MonsterHead();
                    break;
                default:
                    break;
            }
            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    BugBody();
                    break;
                case 3:
                    MonsterBody();
                    break;
                default:
                    break;
            }
            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    BugFeet();
                    break;
                case 3:
                    MonsterFeet();
                    break;
                default:
                    break;
            }
            return;
        }
        static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "ghost":
                    return 1;

                case "bug":
                    return 2;

                case "monster":
                    return 3;

                default:
                    return 1;
            }
        }
        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
