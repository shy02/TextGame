using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    class Class1
    {
        public static void Main(String[] args)
        {
            bool isContinue = true;
            int menu_num = 5;
            while (isContinue)
            {
                Console.WriteLine("┏----------------------------------┓");
                Console.WriteLine("┃ 안녕하세요.                      ┃ ");
                Console.WriteLine("┃ 이 프로그램은 텍스트 게임입니다. ┃");
                Console.WriteLine("│ 아래 메뉴를 선택해주세요.(=      ┃");
                Console.WriteLine("┗----------------------------------┛");
                Console.WriteLine(" ①기본 게임");
                Console.WriteLine(" ②직접 문제 추가하기");
                Console.WriteLine(" ③직접 추가한 게임");

                while(menu_num >= 4) {
                    menu_num = int.Parse(Console.ReadLine());
                    if (menu_num >= 4) Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요");
                }
                switch (menu_num)
                {
                    case 1://기본게임 시작
                        menu_num = 5;
                        Game game = new Game();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }

            }
        }
    }

    class Player
    {
        string name;
        int position = -1;
        public Player(string name, int p)
        {
            this.name = name;
            position = p;
        }
        public void concept(string story)
        {
                Console.WriteLine("\n");
                Console.WriteLine(name + story);
        }
        public string getName()
        {
            return name;
        }
    }
    class Ending
    {
        public void BadEnding()
        {
            Console.WriteLine("");
        }
        public 
    }
    class Game
    {
        int num = 100;
        int Chance = 2;
        public Game()
        {
            Console.Clear();
            Console.WriteLine("이 세상에 재앙이 들이 닥쳤다.");
            Console.WriteLine("온 땅이 풀로 뒤덮이며 사람들은 그 풀에 하나 둘 죽어나갔다.");
            Console.WriteLine("이 사태를 지켜보던 신은 사이좋은 두명의 인간에게 다가갔다.");
            Console.WriteLine(" ");
            Console.WriteLine("┏----------------------------------┓");
            Console.WriteLine("┃ 이 게임은 2인용 게임입니다.      ┃");
            Console.WriteLine("┃ 각각의 역할이 주어집니다.        ┃");
            Console.WriteLine("┃ 서로의 화면을 공유하지 말아주세요┃");
            Console.WriteLine("┗----------------------------------┛");
            Console.WriteLine("준비가 되셨다면 ENTER를 눌러주세요..");

            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
            Console.Write("플레이어 1 당신의 이름은? : ");
            Player player1 = new Player(Console.ReadLine(), 1);
            player1.concept(" 당신은 이 세상을 구할 수 있는 유일한 사람은 아닙니다.\n하지만 당신은 현재 세상을 구하기 가장 쉬운 사람 입니다. \n세상을 구하고 싶다면 당신의 친구를 죽이세요. \n지금은 당신의 친구를 평범한 방법으로는 죽일 수 없을 것 입니다. \n아주 추운 곳에 가면 친구가 약해질 것 입니다. \n친구를 그곳에서 죽이면 당신은 이세상을 구한 영웅이 될 것입니다.\n그곳을 간 이후부터는 신조차 개입할 수 없는 오로지 당신의 선택입니다. \n행운을 빕니다.\n\nps.이 내용은 아무에도 알려선 안됩니다. \n알릴 경우 천벌이 내릴 것 입니다.");
            Console.Write("\n다 읽으셨다면 ENTER를 누르고 친구에게 넘겨주세요...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
            Console.Write("플레이어 2 당신의 이름은? : ");
            Player player2 = new Player(Console.ReadLine(), 2);
            player2.concept(" 당신은 이 세상을 재앙에 빠뜨린 범인입니다.\n당신의 동족들은 당신을 내세워 이 세상의 구인류를 정리하려합니다.\n만약 이 계획을 성공시키고 싶다면 당신의 친구를 죽이십시오.\n당신의 친구도 당신을 죽이라는 지령을 받았을 것입니다.\n살고싶다면 추운 곳에 도달하기 전에 친구를 죽이십시오.\n하지만 대놓고 죽인다면 남은 시간은 당신에게 험난한 시간이 될 것입니다.\n그런 당신을 위해 동족들은 길목에 주술을 걸어 문제를 풀어야만 지나갈 수 있게 하였습니다.\n문제를 2번이상 틀린다면 당신의 친구는 죽을 것 입니다.\n만약 세상을 구하고 싶다면 추운 곳에 도달하여 친구에게 죽으십시오.\n만약 친구를 죽인다면 당신은 신인류의 지배자가 될 것입니다.\n그곳을 간 이후부터는 신조차 개입할 수 없는 오로지 당신의 선택입니다. \n행운을 빕니다.\n\nps.이 내용은 아무에도 알려선 안됩니다. \n알릴 경우 천벌이 내릴 것 입니다.");
            Console.Write("\n다 읽으셨다면 ENTER를 누르고 게임을 시작하세요...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
            Console.Write("여러분은 모험을 떠나는 중 세가지 문제를 만나게 될것입니다.\n");
            Console.Write("세가지 문제를 모두 푼다면 목적지에 도착할 수 있을 것 입니다.\n");
            Console.Write("만약 문제를 틀린다면 기회를 잃게 될 것입니다.\n");
            Console.Write("두번의 기회가 주어지며 전부 틀린다면 당신들은 죽게됩니다. \n명심하세요.");
            Console.Write("\n\n첫번째 문제\n");
            Console.Write("1 + 1 = ?\n");
            Console.Write("① 2 \n②창문 \n③귀요미\n④3\n⑤11\n");
            while (num >= 6)
            {
                Console.Write("답을 입력해주세요 : ");
                num = int.Parse(Console.ReadLine());
                if (num >= 6) Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요\n");
            }
            switch (num)
            {
                case 1://기본게임 시작
                    Console.WriteLine("맞았습니다! 당연히 1 + 1 = 2 이죠! \n길이 열렸습니다. 여러분은 앞으로 나아갑니다.");
                    break;
                case 2:
                    Console.WriteLine("이런..대단하시네요.여러 의미로 \n어이쿠 여러분은 기회를 제물로 앞으로 나아갑니다.");
                    Chance--;
                    break;
                case 3:
                    Console.WriteLine("하하하..참 귀여우시네요..\n어이쿠 여러분은 기회를 제물로 앞으로 나아갑니다.");
                    Chance--;
                    break;
                case 4:
                    Console.WriteLine("대체 왜요..? \n어이쿠 당신들은 기회를 제물로 앞으로 나아갑니다.");
                    Chance--;
                    break;
                case 5:
                    Console.WriteLine("전 이게 제일 이해 안가더라고요. \n어이쿠 당신들은 기회를 제물로 앞으로 나아갑니다.");
                    Chance--;
                    break;
            }
            num = 100;
            Console.Write("\n다 읽으셨다면 ENTER를 눌러주세요...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
            Console.Write("두번째 문제\n");
            Console.Write("스핑크스의 오래된 정답은 무엇일까?\n");
            Console.Write("① 스핑크스 \n②사막 \n③모르겠는데\n④인간\n⑤동물\n");
            while (num >= 6)
            {
                Console.Write("답을 입력해주세요 : ");
                num = int.Parse(Console.ReadLine());
                if (num >= 6) Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요\n");
            }
            num = 100;
            switch (num)
            {
                case 1://기본게임 시작
                    Console.WriteLine("진짜요?.. \n어이쿠 여러분은 기회를 제물로 앞으로 나아갑니다.");
                    Chance--;
                    break;
                case 2:
                    Console.WriteLine("스핑크스라 사막? \n 어이쿠 여러분은 기회를 제물로 앞으로 나아갑니다.");
                    Chance--;
                    break;
                case 3:
                    Console.WriteLine("?ㅋㅋㅋㅋㅋ\n 어이쿠 여러분은 기회를 제물로 앞으로 나아갑니다.");
                    Chance--;
                    break;
                case 4:
                    Console.WriteLine("맞습니다! 아침엔 네발 점심엔 두발 저녁엔 세발! 유명하죠 \n길이 열렸습니다. 여러분은 앞으로 나아갑니다.");
                    break;
                case 5:
                    Console.WriteLine("아..아쉽다 \n 어이쿠 당신들은 기회를 제물로 앞으로 나아갑니다.");
                    Chance--;
                    break;
            }
            if(Chance <= 0)
            {
                Console.WriteLine("유감입니다." + player1.getName() + ".. 당신은 사망하셨습니다.");
                Ending be = new Ending();
                be.BadEnding();


            }
        }
    }
     
}
