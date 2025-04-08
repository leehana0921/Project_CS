using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace NewProject_CS.Scene_Add
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
        public override void Choice() { }
        public override void Result() { }
        public override void Wait() 
        {
            Console.WriteLine("");
            Console.WriteLine("게임 시작을 위해 아무 키나 눌러주세요.");
            Console.ReadKey(true);
        }

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
            Print("평범하다면 평범하다고 할 수 있는 가장인 나는");
            Print("고등학생 때 화재로 부모님을 잃고 쌍둥이 동생둘과 같이 살고 있었다.");
            Print("그렇게 평소와 다름없이 일을 하던 중 회사로 걸려 온 한 통의 전화,");
            Print("갑자기 걸려 온 한 통의 전화는 내 인생을 송두리째 바꿔놓기에는 충분했다.\n");
        }
        public override void Choice() { }
        public override void Result() { }
        public override void Wait()
        {
            Console.WriteLine("");
            Console.WriteLine("▶ 다음 페이지로 넘어가려면 아무 키나 눌러주세요");
            Console.ReadKey(true);
        }

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
            Print("\"유은우 씨 일로 말씀 드리고 싶은 게 있습니다. 잠깐 시간 되십니까?\"\n");
            Print("가슴이 불안했다. 동생들은 부모님이 그렇게 된 후 내게 남은 유일한 가족이었다.\n");
            Print("\"아, 네. 잠시만요.\"\n");
            Print("과장님께 급한 전화가 와 잠시 자리를 비우겠다 말씀 드리고 비상계단으로 갔다.\n");
            Print("\"저희 은우한테 무슨 일이 생긴 걸까요?\"");
            Print("\"유은우 씨가 제게 찾아왔습니다. 자신이 8년 전 유병철 씨 댁에 불을 지른 진범이라고요.\"");
            Print("\"네...? 그, 그럴 리가 없어요. 저희 은우는 그 때 고작 7살이었어요. 그 어린 애가 무슨...\"");
            Print("\"유재현 씨 마음은 잘 압니다. 일단 만나서 얘기 하실까요.\"");
            Print("\"... 네.\"\n");
        }
        public override void Choice() { }
        public override void Result() { }
        public override void Wait()
        {
            Console.WriteLine("");
            Console.WriteLine("▶ 다음 페이지로 넘어가려면 아무 키나 눌러주세요");
            Console.ReadKey(true);
        }

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
            Print("나는 바로 전화를 끊고서는 김민중 형사에게로 갔다.");
            Print("김민중 형사는 회사와 그리 멀지 않은 공원에 있다고 했다.");
            Print("초록 공원에 도착하니 밴치에 앉아있는 검은 재킷을 입은 남자가 보였다.");
            Print("나는 직감적으로 그 남자가 김민중 형사일 거라 직감했다.\n");
            Print("죽일까? \n");
        }

        public override void Choice()
        {
            Console.WriteLine("1. 죽인다.");
            Console.WriteLine("2, 살린다.");
        }
        public override void Result() 
        {
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Print("저 사람만 없으면 우리 은우를 지킬 수 있어...");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Print("아니야, 내가 지금 무슨 생각을...");
                    break;
            }
        }
        public override void Wait() { }
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Game.ChangeScene("ImprisonedEnd1");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Game.ChangeScene("Prolog3");
                    break;
            }
        }
    }
    public class ImprisonedEnd1 : Scene
    {
        private void Print(string text)
        {
            Console.WriteLine(text);
            Thread.Sleep(2000);
        }
        public override void Render()
        {
            Console.WriteLine("");
            Print("마침 그 남자가 앉아있는 밴치는 햇빛이 잘 들지 않아 인적이 드문 자리였다.\n");
            Print("\"...사람이, 잘 오지 않는 자리에 앉아있네.\"\n");
            Print("나는 홀린 듯 소리없이 남자의 뒤쪽으로 다가갔다.");
            Print("남자의 뒤에 거의 다다랐을 즈음, 나는 주변에 아무렇게나 널부러져있는 돌을 하나 집어들었다.\n");
            Print("\"...?\"\n");
            Print("남자가 인기척을 느껴 뒤를 돌아봄과 동시에 그의 머리를 향해 팔을 내리쳤다.\n");
            Print("\"윽...!!\"\n");
            Print("남자는 외마디 비명과 함께 앞으로 고꾸라졌다.");
            Print("나는 멍하니 쓰러진 남자를 응시하다가 가까이 다가갔다.\n");
            Print("\"그러게 왜 그러셨어요. 김민중 형사님.\"\n");
            Print("나는 쓰러져있는 남자의 머리에 다시금 돌을 내리쳤다.");
            Print("얼마쯤 지났을까.");
            Print("내리칠 때마다 작게 경련하던 남자의 몸이 더이상 움직이지 않게 되었고 주변은 남자의 피로 흥건해졌다.");
            Print("피투성이가 된 돌을 내려놓고 나도 바닥에 주저앉았다.");
            Print("나는 작게 중얼거렸다.\n");
            Print("\"이걸로 우리 은우는 지킬 수 있게 됐어... 그거면 된 거야...\"\n");
        }
        public override void Choice() { }
        public override void Result() { }
        public override void Wait()
        {
            Console.WriteLine("");
            Console.WriteLine("▶ 다음 페이지로 넘어가려면 아무 키나 눌러주세요");
            Console.ReadKey(true);
        }
        public override void Next()
        {
            Game.ChangeScene("ImprisonedEnd2");
        }
    }
    public class ImprisonedEnd2 : Scene
    {
        private void Print(string text)
        {
            Console.WriteLine(text);
            Thread.Sleep(2000);
        }
        public override void Render()
        {
            Console.WriteLine("");
            Print("\"... 유재현 씨?\"\n");
            Print("내 이름을 부르는 그 한 마디에 심장이 철렁 내려 앉았다.");
            Print("꽤나 젊어보이는 인상의 남자가 나와 쓰러진 남자를 번갈아보며 입을 열었다.\n");
            Print("\"약속 시간이 한참 지나도 오시지 않으시기에... 와봤는데. 어떻게 된 상황인지는 대충 짐작이 가는 군요.\"\n");
            Print("나는 멍하니 그를 올려다보았다.\n");
            Print("\"서로 함께 가주셔야 겠습니다. 유재현 씨.\"\n");
            Print("찰칵\n");
            Print("나는 내 손목에 수갑을 채우는 그를 뿌리칠 수 없었다.");
            Print("내가 지금 무슨 짓을...");
            Print("멍하니 그를 올려다보며 말했다.");
            Print("\"... 저, 남자는,\"\n");
            Print("목이 메여 말이 잘 나오지 않았으나 겨우 소리를 쥐어짜내어 문장을 완성했다.\n");
            Print("\"죽은, 건가요?\"");
            Print("\"......\"\n");
            Print("김민중 형사가 쓰러진 남자에게 다가가 숨을 쉬는 지 확인하는 듯 했다.\n");
            Print("\"빠르게 조치를 취하면 혹시 모를 일이지요.\"\n");
            Print("그는 그대로 휴대폰을 들어 어딘가로 연락을 하는 듯 했고, 등 뒤로 울리는 사이렌 소리를 뒤로 하며 나는 김민중 형사의 차에 올라탔다.\n");
        }
        public override void Choice() { }
        public override void Result() { }
        public override void Wait()
        {
            Console.WriteLine("");
            Console.WriteLine("▶ 다음 페이지로 넘어가려면 아무 키나 눌러주세요");
            Console.ReadKey(true);
        }
        public override void Next()
        {
            Game.Gameover("당신은 형사를 죽여 진실을 은폐한 뒤 따로 조사를 할 생각이었지만 진짜 김민중 형사에게 딱 들키고 말았군요.\n다음에는 불안에 사로 잡히지 말고 더욱 현명한 판단을 하시길 바랍니다.");
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
            Print("김민중 형사가 내 눈을 마주치며 말했다.\n");
        }
        public override void Choice() { }
        public override void Result() { }
        public override void Wait()
        {
            Console.WriteLine("");
            Console.WriteLine("▶ 다음 페이지로 넘어가려면 아무 키나 눌러주세요");
            Console.ReadKey(true);
        }
        public override void Next()
        {
            Game.ChangeScene("Prolog4");
        }
    }
    public class PrologScene4 : Scene
    {
        private void Print(string text)
        {
            Console.WriteLine(text);
            Thread.Sleep(2000);
        }
        public override void Render()
        {
            Console.WriteLine("");
            Print("\"자기가 8년 전 유병철 씨네 집에 불을 질렀다고.");
            Print("그 말을 남기고는 어딘가로 사라졌습니다.");
            Print("저는 그 이후로 당시 초록마을 화재 사건을 계속 조사했습니다.");
            Print("아직 동료들에게 따로 알리지는 않고 혼자 자체적으로 조사중이라 큰 진전은 없지만 한 가지는 확실히 알겠더군요.\"\n");
            Print("나도 모르게 마른 침을 삼켰다.\n");
            Print("\"유병철 씨 사건에는 유재현 씨의 쌍둥이 동생 분들이 둘 다 관련되어있습니다.");
            Print("이게 당시 찍혔던 CCTV인데 화재 바로 전 두 사람이 대화를 나누는 장면이 찍혀 있습니다.\"\n");
            Print("김민중은 품에서 USB를 하나 꺼내며 말했다.\n");
            Print("\"유은우 씨와 유은오 씨.");
            Print("이틀 전 유재현 씨께는 놀러간다고 말씀 드렸던 것 같은데, 두 분께 따로 온 연락이 있었나요?\"\n");
            Print("아니. 없었다.");
            Print("그저 노느라 즐거워서, 형 생각이 나지 않을만큼 즐거워서 그런 거라고 생각했었다. ");
            Print("\"이틀 전부터 유은우 씨와 유은오 씨의 행방이 묘연합니다.");
            Print("마치 이 세상에서 사라진 것처럼 말이죠.\"\n");
            Print("짐작가는 부분이 있느냐 묻는 김민중의 말도 귀에 들어오지 않았다.");
            Print("아직 어린애들인데, 그저 내가 힘들다는 이유로 최근 전혀 신경 써주지 못했다.");
            Print("애들한테 무슨 일이 생기게 된다면 이건 온전히 내 책임이었다.");
            Print("스물스물 피어난 불안감이 가슴을 옥죄였다.\n");
            Print("\"정신 차리세요. 유재현 씨.\"\n");
        }

        public override void Choice() { }
        public override void Result() { }
        public override void Wait() 
        {
            Console.WriteLine("");
            Console.WriteLine("▶ 다음 페이지로 넘어가려면 아무 키나 눌러주세요");
            Console.ReadKey(true);
        }
        public override void Next()
        {
            Game.ChangeScene("Prolog5");
        }
    }
}
        

    
