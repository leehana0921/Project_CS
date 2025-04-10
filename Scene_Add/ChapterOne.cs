using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_CS.Scene_Add
{
    public class ChapterOneScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("한순간에 정신이 번쩍 들었다.");
            Print("그래, 애들의 보호자인 내가 벌써부터 흔들리면 안 되지.");
            Print("우선 동생을 찾는 것만 생각하자.\n");
        }
        public override void Choice()
        {
            Console.WriteLine("1. \"형사님은 애들이 놀러 갔다는 건 어떻게 아셨습니까?\"");
            Console.WriteLine("2. \"애들한테 연락이 따로 없었다는 건 어떻게 아셨습니까?\"");
        }
        public override void Result() {
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Game.Player.observation = Game.Player.observation + 1;
                    Print("\"말씀 드렸잖습니까. 자체적으로 조사중이었다고.");
                    Print("아무리 성숙해도 애들은 애들이라 누구라도 자신의 마음을 알아주길 바랐을 겁니다.\"");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    PrintText("\"생각보다 눈치가 빠르네?\"");
                    break;
            }
        }
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Game.ChangeScene("ChapterOne1");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Game.ChangeScene("DeadEnd");
                    break;
            }
        }
    
    }
    public class DeadEndScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("\"뭐?\"\n");
            Print("퍼억\n");
            Print("둔탁한 소리와 함께 내 몸이 앞으로 고꾸라졌다.");
            Print("뒤통수에서 아릿한 통증이 느껴졌다.");
            Print("이게 지금 어떻게 된 일인 거지...?\n");
            Print("\"설마 내 말을 진짜 믿었어?\"");
            Print("\"이, 게... 무슨...\"");
            Print("\"아직 말 할 기운이 남아있나보네?");
            Print("유재현. 당신 지금 나한테 속은 거야.");
            Print("당신이 금이야 옥이야 키운 동생들은 지금 내가 데리고 있다?");
            Print("7년 전 당신 집에 불 지른 거 사실 나거든.");
            Print("유은우는 잘 구슬려서 나 대신 감옥에 보낼 거고");
            Print("유은오는 뭐... 꽤 내 취향이던데 내가 입맛대로 예쁘게 키워줄게.");
            Print("너무 걱정하지는 마. 내가 잔뜩 예뻐해줄테니까.\"\n");
            Print("내 동생을 희롱하며, 녀석은 나를 끝까지 농락했다.\n");
            Print("\"지속되는 학대에 지쳐 부모님을 살해한 아들!");
            Print("그리고 마침내 자신의 형제들마저 죽인 뒤 홀연히 자취를 감추다!");
            Print("어때? 뉴스 1면으로 딱이지 않아?\"");
            Print("\"미친... 새...\"");
            Print("\"아직도 말 할 기운 있으면 당신 동생들이나 걱정하는 게 어때?");
            Print("한 놈은 평생을 도망자 신세로 살다가 잡히면 남은 여생을 유치장에서 썩을 놈이고,");
            Print("한 놈은 가족의 원수 손에 평생 길러지게 될텐데 말이야.\"\n");
            Print("아, 피를 너무 많이 흘렸다.");
            Print("흐려지는 시야 안에 홀연히 떠나는 녀석의 뒷모습만이 보였다.\n");
            Print("형이 끝까지 너희를 지켜주지 못해서 미안해...\n");
            Print("나는 더이상 흐르는 눈물을 주체 할 수 없었고, 그렇게 눈을 감았다.\n");
        }
        public override void Choice() { }
        public override void Result() { }
        public override void Next()
        {
            Game.Gameover("당신은 진짜 범인에게 사랑하는 동생들을 뺴앗기고 목숨도 잃었습니다.");
        }
    }
    public class ChapterOneScene1 : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("김민중 씨는 휴대폰 화면을 내게 내밀었고 나는 그것을 받아들었다.");
            Print("그 안에는 아이들이 올린 SNS 게시물이 있었다.\n");
            Print("\"... 애들이 SNS를 하는 줄도 모르는 못난 형이었군요, 저는.\"");
            Print("\"그게 아닙니다, 유재현 씨.\"");
            Print("\"네?\"");
            Print("\"잘보십시오.\"");
            Print("\"대체 무슨 말씀을 하시는 건지...\"\n");
            Print("영문을 모르겠다는 표정으로 쳐다보자 손으로 게시글의 한 부분을 짚어줬다.\n");
            Print("\'드디어 은오랑 같이 온 파란 마을. 너무너무 긴장된다");
            Print("12월 3일 오후 8시. 드디어 마지막이야.");
            Print("형이랑 같이 오고 싶었지만 그건 안 되겠지. 언젠가 꼭 같이 오자, 형!\'");

        }
        public override void Choice()
        {
            Console.WriteLine("1. \"같이 여행에 가고 싶었는데 내가 몰라줬구나...\"");
            Console.WriteLine("2. \"파란 마을로 간다는 말은 없었는데...\"");
            Console.WriteLine("3. \"12월 3일? 오늘 집으로 돌아오겠네요?\"");
        }
        public override void Result() {
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Game.Player.observation = Game.Player.observation - 1;
                    Print("\"지금 그게 중요한 게 아닙니다.\"");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Game.Player.observation = Game.Player.observation + 1;
                    Print("\"아마 유재현 씨에게는 목적을 알리고 싶지 않았을 겁니다.\"");
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Game.Player.observation = Game.Player.observation + 2;
                    Print("\"정말 집으로 돌아올 거라고 생각합니까?\"");
                    break;
            }
        }
        public override void Next()
        {
            Game.ChangeScene("ChapterOne2");
        }
    }
    public class ChapterOneScene2 : Scene
    {
 
        public override void Render()
        {
            Console.WriteLine("");
            Print("\"네? 그게 무슨 말씀이시죠?\"");
            Print("\"이쪽을 읽어보시면 유은우 씨랑 유은오 씨는 이전부터 파란 마을에서 해야 할 무언가가 있었을 겁니다.");
            Print("다만 아직까지는 준비가 안 되어있었던 것 같고요.");
            Print("그런데 그게 마침 준비가 되었고, 오늘 오후 8시에 마지막으로 해야 할 무언가만 남아있다는 것 같습니다. ");
            Print("물론 그건 유재현 씨 모르게 행해야 하는 것이겠지요.");
            Print("혹시 짐작가는 거 없으십니까?");
            Print("\"... 모르겠습니다. 더군다나 저는 파란 마을에 가본적이 없습니다.\"");
            Print("\"흠. 그렇군요. 지금 시간이 딱 5시이니 서둘러 출발해야 할 것 같습니다.");
            Print("다행히 파란 마을까지는 얼마 안 걸리니 사진에 나와있는 장소로 가서 단서를 수집하도록 합시다.\"\n");
            Print("이 사람은 경찰인데 내가 믿어도 될까?");
            Print("애들을 찾았는데 만약 진짜로 부모님을 죽인 게 은우라면?");
            Print("우리 은우는 무사 할 수 있는 걸까?\n");
            Console.Clear();
            Console.WriteLine("");
            PrintText("역시... 죽일까?");
        }
        public void Render1()
        {
            
        }
        public override void Choice()
        {
            Console.WriteLine("1. 죽인다.");
            Console.WriteLine("2. 살린다.");
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Print("아니야. 냉정하게 생각해 볼 때 혼자서 3시간 안에 애들을 찾는 건 무리야.");
                    Print("하지만 최소한의 안전장치정도는 해 두는 게 좋겠지.\n");
                    Print("\"역시 USB정도는 제가 갖고 있어야 할 것 같습니다.");
                    Print("저희가 완벽한 신뢰 관계는 아니잖아요.\"");
                    Print("\"... 알겠습니다. 그정도는 드리는 게 맞겠지요.\"\n");
                    Print("USB를 손에 넣었다!");
                    inventory.Add("usb");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Print("아니야. 그런 이유로 지금 이 사람을 죽이게 되면 동생들을 다시는 볼 수 없게 될 수도 있어.");
                    Print("생각보다 머리가 잘 돌아가는 사람이다.");
                    Print("애들을 찾는 일에 분명 도움이 될 거야.");
                    break;
            }
        }
        public override void Next()
        {
            Game.ChangeScene("ChapterOne3");
        }
    }
    public class ChapterOneScene3 : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("\"안 가십니까? 저 차 안 가져왔습니다.\"");
            Print("\"아, 가시죠. 이쪽입니다.\"\n");
            Print("서둘러 일어난 나는 김민중 씨와 함께 차로 향했다.\n");
            Print("\"사진에 있는 장소는 파란 마을 시청쪽인 것 같습니다.");
            Print("대략 30분정도 소요 되겠군요.\"");
            Print("\"저, 형사님. 궁금한 게 있습니다.\"");
            Print("\"말씀하셔도 됩니다.\"");
            Print("\"그 USB에는 어떤 내용이 들어있습니까?");
            Print("동생들이 그 날 무슨 대화를 한 건지 다 녹음이 되어있는 겁니까?\"");
            Print("\"정확하게 다 녹음이 되어있는 것은 아닙니다.");
            Print("아무래도 거리가 있다보니 녹음 된 내용이 거의 없는 거나 마찬가지입니다.\"");
            Print("\"아... 그럼 딱히 건질만한 내용같은 건 없겠네요.\"");
            Print("\"그럴 수도 있겠지만 중간중간 잘 들리는 부분도 있어서 유재현 씨가 영상을 직접 봐주시면 더 좋을텐데요.");
            Print("물론 지금은 볼 수가 없으니 따로 방도는 없겠습니다.\"");
            Print("\"혹시 애들이 어떤 대화를 나눴나요?\"");
            Print("\"언쟁을 벌이는 듯 해 보였습니다.");
            Print("중간중간 유재현 씨 이름도 나왔고요.");
            Print("끊겨들린데다가 아무래도 저는 유재현 씨 가족 분들의 사정은 잘 모르니까요.\"\n");
            Print("... 언쟁이라.\n");
            Print("\"그 날 대체 무슨 일이 있었던 거야...\"\n");
            Print("나는 입술을 깨물며 초초한 마음을 뒤로 한 채 악셀을 더 쎄게 밟을 뿐이었다.\n");
        }
        public override void Choice()
        {
            Console.WriteLine("");
            Console.WriteLine("▶ 다음 페이지로 넘어가려면 아무 키나 눌러주세요");
            Console.ReadKey(true);
        }
        public override void Result() { }
        public override void Next()
        {
            Game.ChangeScene("BlueTown");
        }

    }
}
