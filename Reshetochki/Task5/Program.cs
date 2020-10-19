using System;
using Switch_Lib;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            SwitchLib.FunctionDelegat function1, function2, function3;
            function1 = Library;
            function3 = Task3; //!!! <- delete comment after corecting
            SwitchLib f = new SwitchLib();
            f.Switch(function1, function2, function3);
            Console.ReadKey();
            
            Horoscope.Horo one = new Horoscope.Horo();
            one.zodiac_sign();
        }
        public static void Library()
        {
            Console.WriteLine("I just creat a library");
        }
        
        public static void Task3() //!!! <- delete comment after corecting
        {

        }
    }
    
    
namespace Horoscope
{
    class Horo
    {
        public int day;
        public string month;

        public void zodiac_sign()
        {
            Console.Write("Enter the month of birth (for example: january): ");
            string month = Console.ReadLine();
            Console.Write("Enter the day of birth: ");
            int day = Convert.ToInt32(Console.ReadLine());


            if ((month == "march" && day >= 21) || (month == "april" && day <= 20))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Your zodiac sign is aries" + "\nAries often thinks that they are right in everything and are difficult to convince. You can't explain to him that the code is bad, that he has a conflict with QA, or the solution is wrong! Aries has a strong personality and strong leadership qualities, which is why he is often found among technical project leaders or business leaders. Aries' honesty knows no limits, they can tell the client and the manager everything they think about the project, and for one and on their account. Aries programmers are full of new ideas, but they are trying to push their implementation onto junior developers. Aries love to seek adventure on their project and take off as a team, you are unlikely to ever get bored. In a difficult situation, he always expects explanations from the manager, and the sooner he receives them, the better. The manager needs to let Aries speak and pour out his soul, then it will become easier for him! Do not think that Aries is aggressively opposed to you, the client, or the team, he is really rooting for the common cause and wants to fix the problem as soon as possible.");
            }
            else if ((month == "april" && day >= 21) || (month == "may" && day <= 21))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your zodiac sign is taurus" + "\nThe developers of this sign are stubbornly superior to Aries, but Taurus has a slight negligence in the gita, when everything is clear for Aries. The Taurus programmer can be very stubborn, he will not respond for a long time to the request of the Tech Lead to remove all unnecessary from the git, or the desire of the system administrator to clean all unnecessary in his PC. Taurus does not like changes, therefore, he does not like to change projects, he is very attached to teams, a client or a manager. For the right to work in the old team, he will sign under any term and terms of reference. And in general, everything new is painful, he will never support the idea of ​​transferring a project to a new technology stack. Taurus hope that new demands from the client, communication problems, and the way out of assessments will be settled on their own without any intervention on their part.However, if the Taurus developer began to express something to you, you should know that he endured for a very long time and now this patience has come to an end.Pay attention to it, show concern and the conflict will be settled.The recommended programming language is PHP.");
            }
            else if ((month == "may" && day >= 22) || (month == "june" && day <= 21))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Your zodiac sign is gemini" + "\nWith them, the team is very noisy, and even if you have one twin developer, it seems that there are two of them, or even four, in terms of the amount of information transmitted. They can take up all of the meeting time, you have to organize a few more in the hope of allowing other team members to speak, but they will take additional time for additional meetings. The twins manage to manage to do several things at the same time and write the code, do the technical assignment, and test and correct the designer. At the same time, it always seems to them that life is passing by, that their productivity is low, that they are overestimated, even if they have a dozen simultaneous projects.Despite striving for independence, Gemini works great in teams of programmers, feeling the need for parallel programming, a curator or mentor.When problems or conflicts within the team appear on a project, the Gemini try to switch to another project or hide. If you want to direct their activities in the right direction, make an appointment with them, draw up a plan for their development, go through the project plan and argue your desire to engage them with specific tasks.They take logic very well.The recommended programming language is Python.");
            }
            else if ((month == "june" && day >= 22) || (month == "july" && day <= 22))
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Your zodiac sign is cancer" + "\nCancer takes a very responsible approach to work issues, while he is very sensitive and vulnerable. One negative feedback from a customer can knock them out of the workflow for weeks. Therefore, it is so important to filter the entire flow of information entering for him, from clients to company solutions.Take care of crayfish! It is best to solve the problem before he himself understands what is happening around him.Cancer can imagine a missed deadline, imbued with this picture and believe in its reality, and then complain to the manager that the project is going to hell.Very often, when choosing new programming languages ​​in Cancer, a skeptic suspect is included. Cancer is most suited to work on his own project, the team often upsets him.However, the results of his work are excellent, he is demanding of himself and customer - oriented, he is able to predict the emergence of risks on the project and eliminate their symptoms in advance.As a rule, Cancer is an excellent systems architect.The recommended development platform is .NET.");
            }
            else if ((month == "july" && day >= 23) || (month == "august" && day <= 21))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Your zodiac sign is lion" + "\nLeo believes in perfect code, or rather in his own code. He highly values ​​the results of his work and is happy when others notice it. He loves compliments, so he always tries to get feedback from clients or managers. What would you do without me - he makes it clear to the entire project team. Able to one day go out to work overtime, but not just like that, but so that everyone once again imbued with his uniqueness and indispensability. Get hurt. If someone offends him, then it becomes very difficult to work with him. He will refer the manager to the rules and instructions, which, of course, do not describe in detail what exactly is required of the employee. It is better for Leo to go to test automation or 1C, but it is worth noting that Leo can use a variety of programming languages ​​with the same skill.");
            }
            else if ((month == "august" && day >= 22) || (month == "september" && day <= 23))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your zodiac sign is virgo" + "\nVirgo is a cruel realist coder. These programmers are able to talk nicely with the manager about the next batch of edits and go to work on the weekend, and draw pictures of revenge in their heads. They love accuracy in work, planning, they even drink tea on schedule, because everything should be in order.Virgo loves to play on the manager's nerves and begin to suffer for the public that the project is uninteresting, the customer is inadequate and in general everything is decay. However, on my personal projects I am ready to sit at night and at the same time get real pleasure from coding. It's a pity that he quickly loses interest in them.If you want to discuss problems on the project with Virgo - prepare for a meeting in advance, think over scenarios of her behavior, choose words.The main thing is to earn trust, and then it will be easier Virgos are great at programming in Objective C and Swift.");
            }
            else if ((month == "september" && day >= 24) || (month == "october" && day <= 23))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Your zodiac sign is libra" + "\nThe Libra programmer doesn't like planning because he is not good at it. Hard to give estimates. Libra is always looking for ideals: perfect project, perfect manager, perfect code. But there is not enough time to learn the rules for working with Jira or write legible and understandable reports. He loves fashion trends in development, while he can make decisions on small issues for a long time: github vs gitlab; objective C vs Swift, etc. Always looking for balance, but the programming nature outweighs the highly spiritual ideals. Has often a cognitive dissonance between reality and the desired. The presence of Libra on the team is always welcomed by its members, because it is Libra who is ready to take all the blame for the failure on the project on themselves.It is so easier for them than to listen to arguments for a long time, who is right and who is wrong.If the Libra programmer gets angry with you, in a fit of revenge he is able to write viruses that kill everyone and everything on the project, so be vigilant and do not quarrel with Libra.Recommended programming languages: C++, C #");
            }
            else if ((month == "october" && day >= 24) || (month == "november" && day <= 22))
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Your zodiac sign is scorpio" + "\nThe most secretive, but at the same time quick-tempered developer on the team. It is almost impossible to get information from a Scorpio on a ready-made solution if he is not ready to share with it. Introducing a new employee into the project in the place of Scorpio is very difficult if this process was not initiated from him. Very stubborn, almost like Aries. Even if he chose a thorny, thorny path, he will pass it to the end and will not give up, but will not complain either. Not a fan of creating a backend, more inclined to work with FrontEnd.The team quickly identifies the weaknesses of colleagues and, in particular, the manager, and then uses it for their own selfish purposes.At the same time, I am glad to share ideas for improvement, and he has a lot of them.He loves himself very much, can admire his photo on the honor board for hours. Working with him as a team is difficult, but possible.Constant deadlines will help improve the atmosphere in a team with Scorpio, so that there is no time to be distracted and do some inappropriate stupidity.");
            }
            else if ((month == "november" && day >= 23) || (month == "december" && day <= 22))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Your zodiac sign is sagittarius" + "\nSagittarius are philosophers by nature. They love to speculate about the eternal, while trying to impose their opinion not only on the team members, but also on the manager and client, and managers and directors. If they speak to the point, then it is perceived as a healthy initiative, and if not, then as idle talk. At the same time, they are very upset and perplexed when the listeners are inclined to the second option. If you are on the same team on a project with an archer, you have every chance to complete it successfully, no matter how high the risks, uncertain requirements and intractable customer are.Sagittarius possesses intuition and the ability to get out safely from any, even the most difficult, alterations.For this he is very much loved in the team, so he easily acquires friends and allies.Do not offend the archers, they can take cruel revenge on you, if by the time the plan of revenge is implemented, they have not cooled down, which often happens.Sagittarius are quick - witted. The Sagittarius cannot hold information in himself, telling everyone the truth about the problems of the project, even if it is a client, manager or director of the company in which he works.He can blurt out access, know - how, or salaries of other employees.Endowed with an innate penchant for programming, mobile applications for Android are especially good.");
            }
            else if ((month == "december" && day >= 23) || (month == "january" && day <= 20))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your zodiac sign is capricorn" + "\nIf the new member of your project team is Capricorn, you may think that he is desperately mournful, dreary, bleak and sad. It will seem to you that his day begins with the phrase 'no matter how bad I am today, tomorrow will probably be even worse.' Do not succumb to the first impression, because Capricorn's happiness is in his work, and he plunges into it completely and without a trace. In the project, Capricorn determines the goal in advance, plans the architecture, develops the details, makes risks, so as not to be distracted in the future by trifles. Often he takes over the manager's work, which makes him very happy. You will not find Capricorns idly wandering around the office.If there are no tasks on the project, he will come up with something to do in the form of refactorings and optimizations, he will plan for the manager and do test scripts for QA. You will not get bored with him in the team, he will find how to pin a colleague or leave some surprise in the gita.If you calmly discuss problems with him, then you will receive a solution quickly.Never raise your voice at Capricorns, they will not forgive you.And yes, he is great at programming in Ruby.");
            }
            else if ((month == "january" && day >= 21) || (month == "february" && day <= 19))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Your zodiac sign is aquarius" + "\nSpecial features of this developer - like all managers, everyone wants him to join the team. There are several reasons for this. First, Aquarians never stop at what they have achieved, strive to endlessly improve their programs, refactor and optimize. Secondly, they are very worried if something does not work, which causes sympathy. Thirdly, even if all the projects of the Aquarius were failed with a collapse and all deadlines were thwarted, they manage to distribute advice to colleagues that, to everyone's surprise, work. There is no Aquarius without failed projects in the past. They also break the rules without remorse, sometimes even with joy. If a difficult situation arises in the project, you will not be able to predict how Aquarius will behave.He can actively participate in the team development of solutions to problems, he can laugh off everything, or he can ask for solitude to think about everything that is happening.It is a pity that at such moments, he may not return soon, but when the storm has already subsided. Thanks to their developed imagination, Aquarians have a penchant for creating computer games.");
            }
            else if ((month == "february" && day >= 20) || (month == "march" && day <= 20))
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Your zodiac sign is picses" + "\nThe code of these programmers is unique, they don't like looking for ready-made solutions, they like to create themselves. That is why the first phrase of this programmer when receiving someone's project will be: 'Rewrite!' In addition, he will rewrite, even if secretly from everyone. It is very difficult to accuse him of violating the rules, the Pisces developer has the unique ability to make honest bottomless eyes, and the manager and even the client will believe him that he is not guilty of anything. They can lie at the expense of estimates, just in case. However, you should not take offense at them, their conscience is as well developed as the ability to invent. Coming to a project, Pisces draws images of an ideal client, team, manager, and then take offense at everyone that in reality they are not the same as in Pisces' imagination. Very vulnerable. They can easily abstract themselves from work, leaving for their underwater world. At the same time, they return quickly, full of energy and enthusiasm.");
            }
            else
            {
                Console.WriteLine("Error! Try again");
            }
        }
    }
}
}
