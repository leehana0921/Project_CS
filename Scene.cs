using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace NewProject_CS
{
    public abstract class Scene
    {
        protected ConsoleKey input;
        public abstract void Render();
        public abstract void Choice();
        public void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public abstract void Result();
        public abstract void Wait();
        public abstract void Next();
    }
    public class TitleScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("===========================================================");
            Console.WriteLine("");
            Console.WriteLine("     ____ ____  ___ __  __ ___ _   _    _    _     ");
            Console.WriteLine("    / ___|  _ \\|_ _|  \\/  |_ _| \\ | |  / \\  | |    ");
            Console.WriteLine("   | |   | |_) || || |\\/| || ||  \\| | / _ \\ | |    ");
            Console.WriteLine("   | |___|  _ < | || |  | || || |\\  |/ ___ \\| |___ ");
            Console.WriteLine("   \\____|_| \\_\\___|_|  |_|___|_| \\_/_/   \\_\\_____|");
            Console.WriteLine("");
            Console.WriteLine("===========================================================");
        }
        public override void Result() { }
        public override void Choice()
        {
            Console.WriteLine("");
            Console.WriteLine("게임 시작을 위해 아무 키나 눌러주세요.");
            Console.ReadKey(true);
        }
        public override void Wait() { }

        public override void Next()
        {
            Game.ChangeScene("Prolog");
        }
    }
    public class PrologScene : Scene
    {
        private void Print(string text)
        {
            Console.WriteLine(text);
            Thread.Sleep(2000);
        }
        public override void Render()
        {
            Console.WriteLine("");
            Print("평범하다면 평범 할 수 있는 가장인 나는 \n");
            Print("고등학생 때 화재로 부모님을 잃고 쌍둥이 동생 둘과 같이 살고 있었다.\n");
            Print("그렇게 평소와 다름없이 일을 하던 중 회사로 걸려 온 한 통의 전화,\n");
            Print("갑자기 걸려 온 한 통의 전화는 내 인생을 송두리째 바꿔놓기에는 충분했다.\n");
        }
        public override void Result() { }
        public override void Choice()
        {
            Console.WriteLine("");
            Console.WriteLine("▶ 다음 페이지로 넘어가려면 아무 키나 눌러주세요");
            Console.ReadKey(true);
        }
        public override void Wait() { }

        public override void Next()
        {
            Game.ChangeScene("Prolog1");
        }
    }
    public class PrologScene1 : Scene
    {
        private void Print(string text)
        {
            Console.WriteLine(text);
            Thread.Sleep(2000);
        }
        public override void Render()
        {
            Console.WriteLine("");
            Print("따르릉\n");
            Print("\"전화 받았습니다, 유재현입니다.\"");
            Print("\"안녕하십니까. 초록마을 경찰서의 김민우 형사입니다.\"");
            Print("\"아, 형사님 안녕하세요. 그런데 무슨 일로...?\"");
            Print("\"유은우 씨 일로 말씀 드리고 싶은 일이 있습니다. 잠깐 시간 되십니까?\"\n");
            Print("가슴이 불안했다. 부모님이 그렇게 된 후 내게 남은 유일한 가족이었다.\n");
            Print("\"아, 네. 잠시만요.\"\n");
            Print("과장님께 급한 전화가 와 잠시 자리를 비우겠다 말씀 드리고 비상계단으로 갔다.\n");
            Print("\"저희 은우한테 무슨 일이 생긴 걸까요?\"");
            Print("\"유은우 씨가 제게 찾아왔습니다. 자신이 8년 전 유병철 씨 댁에 불을 지른 진범이라고요.\"");
            Print("\"네...? 그, 그럴 리가 없어요. 저희 은우는 그 때 고작 7살이었어요. 그 어린 애가 무슨...\"");
            Print("\"유재현 씨 마음은 잘 압니다. 일단 만나서 얘기 하실까요.\"");
            Print("\"... 네.\"\n");
        }
        public override void Result() { }

        public override void Choice()
        {
            Console.WriteLine("");
            Console.WriteLine("▶ 다음 페이지로 넘어가려면 아무 키나 눌러주세요");
            Console.ReadKey(true);
        }
        public override void Wait() { }

        public override void Next()
        {
            Game.ChangeScene("Prolog2");
        }
    }
    public class PrologScene2 : Scene
    {
        private void Print(string text)
        {
            Console.WriteLine(text);
            Thread.Sleep(2000);
        }
        public override void Render()
        {
            Console.WriteLine("");
            Print("나는 바로 전화를 끊고서는 김민중 형사에게로 갔다.\n");
            Print("김민중 형사는 회사와 그리 멀지 않은 공원에 있다고 했다.\n");
            Print("초록 공원에 도착하니 밴치에 앉아있는 검은 재킷을 입은 남자가 보였다.\n");
            Print("나는 직감적으로 그 남자가 김민중 형사일 거라 직감했다.\n");
            Print("죽일까? \n");
        }
        public override void Result() { }
        public override void Choice()
        {
            Console.WriteLine("1. 죽인다.");
            Console.WriteLine("2, 살린다.");
        }
        public override void Wait() { }
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Game.ChangeScene("");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Game.ChangeScene("Prolog3");
                    break;
                default:
                    Console.WriteLine("잘못 입력 하셨습니다. 다시 입력해주세요.");
                    return;
            }
        }
    }
    public class PrologScene3 : Scene
    {
        private void Print(string text)
        {
            Console.WriteLine(text);
            Thread.Sleep(2000);
        }
        public override void Render()
        {
            Console.WriteLine("");
            Print("아니야, 내가 지금 무슨 생각을...\n");
            Print("아직 나에게 하지 않은 말이 있을 수도 있잖아. 일단 가보자.\n");
            Print("\"안녕하세요, 유재현입니다. 김민중 형사님 맞으십니까?\"");
            Print("\"아. 오셨군요. 김민중입니다.\"");
            Print("\"하실 말씀이시라는 게 뭔지 들어볼 수 있을까요?\"");
            Print("\"아 그렇죠. 말씀드리겠습니다. 우선 앉으시겠습니까?\"\n");
            Print("나는 말없이 김민중 형사의 옆에 앉은 뒤 어서 말하라는 듯이 그를 쳐다보았다.\n");
            Print("\"음, 어디부터 말씀 드리면 좋을지,,,");
            Print("우선 제가 유은우 씨를 알게 된 건 보름 전입니다.");
            Print("제가 형사라는 것을 알고 있었는지 지나가던 저를 불러세우고는 할 말이 있다고 했었죠. ");
            Print("그리고 딱 이 밴치에 앉아 이야기를 나눴습니다.\"\n");
            Print("김민중 형사가 내 눈을 마주치며 말했다.");
        }
        public override void Result() { }
        public override void Choice()
        {
            Console.WriteLine("");
            Console.WriteLine("▶ 다음 페이지로 넘어가려면 아무 키나 눌러주세요");
            Console.ReadKey(true);
        }
        public override void Wait() { }
        public override void Next()
        {
            Game.ChangeScene("Prolog4");
        }
    }
}
        

    
