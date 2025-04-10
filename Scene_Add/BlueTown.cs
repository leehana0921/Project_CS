using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_CS.Scene_Add
{
    public class BlueTownScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("\"여기가 파란 마을 시청입니다만 저도 두 번밖에 와 본 적이 없어서 길은 잘모릅니다.\"");
            Print("\"이제 어쩌면 좋죠? 이 짧은 시간 안에 동생들을 어떻게 찾아야 할 지...\"");
            Print("\"주변 상가 사람들에게 물어보는 건 어떻겠습니까?\"");
            Print("\"좋은 생각인 것 같아요. 그럼...\"\n");
        }
        public override void Choice()
        {
            Console.WriteLine("");
            Console.WriteLine("1. \"시청 옆 편의점 직원한테 물어볼까요?\"");
            Console.WriteLine("2. \"시청 앞 음식점 직원한테 물어보는 건 어떨까요?\" ");
            if (Game.Player.observation >= 5)
            {
                Console.WriteLine("3. \"아까 본 사진에 저 문구점 간판이 찍혀있었어요. 문구점 사장님한테 물어보는 건 어떨까요?\"");
            }
            Console.ReadKey(true);
        }
        public override void Result()
        {
            Print("\"좋은 생각입니다. 바로 가시죠.\"");
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Game.Player.observation = Game.Player.observation - 1;
                    Game.ChangeScene("BlueTownShop");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Game.Player.observation = Game.Player.observation - 1;
                    Game.ChangeScene("BlueTownShop");
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Game.ChangeScene("BlueTownEvidence");
                    break;
            }
        }
    }
    public class BlueTownSceneShop : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("\"안녕하세요. 초록마을 경찰서에서 온 김민중 형사입니다.");
            Print("잠시 여쭤보고 싶은 게 있는데 시간 괜찮으십니까?\"");
            Print("\"아 네네. 무슨 일이세요, 형사님?\"");
            Print("\"지금 아이 둘이 실종 돼서 찾고 있는데 혹시 이렇게 생긴 아이들 보셨습니까?\"\n");
            Print("김민중 씨는 품에서 휴대폰을 꺼내 동생들의 사진을 보여줬다.");
            Print("사진을 본 직원은 잠시 생각하는 듯 하더니 이내 입을 열었다.\n");
            Print("\"음. 저는 못본 아이들인 것 같아요.\"");
            Print("\"아... 그러시군요.\"\n");
            Print("내가 아쉬움을 감추지 못하자 직원은 사진을 한 번 더 보더니 다시 말했다.\n");
            Print("\"근데 여기 사진에 나온 곳이 요 옆 문구점이거든요.");
            Print("문구점 사장님한테 여쭤보시면 뭐라도 알고 계실 수도 있어요.\"");
            Print("\"감사합니다!\"\n");
            Print("나는 잽싸게 고개를 숙여 인사를 한 뒤 사진에 보이는 간판과 같은 간판을 찾기 시작했다.\n");
            Print("\"유재현 씨. 간판 찾았습니다. 얼른 가봅시다.\"\n");

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
            Game.ChangeScene("BlueTownEvidence");
        }
    }
    public class BlueTownSceneEvidence : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("\"안녕하세요. 초록마을 경찰서에서 온 김민중 형사입니다.");
            Print("잠시 여쭤보고 싶은 게 있는데 잠시 괜찮으십니까?\"");
            Print("\"형사님이 여긴 웬일이래요?\"");
            Print("\"저희가 지금 사진에 찍힌 학생들을 찾고 있는데 혹시 보신 적 없으십니까?\"");
            Print("\"어디 보자...\"\n");
            Print("중년의 사장님이 안경을 고쳐쓰시며 김민중씨가 내민 휴대폰을 받아들었다.\n");
            Print("\"어, 이 학생들 며칠 전에 잔뜩 신나서 왔었어요.");
            Print("오늘 아마 청록산에 있는 팔각정에 간다고 했었던 것 같은데.\"");
            Print("\"청록산이요?\"");
            Print("\"예. 되게 기대된다고 하면서 색종이를 왕창 사가길래 내가 더 챙겨줬었어요.");
            Print("있는 거 거의 다 사갔으니 잊을 수가 없지요.\"");
            Print("\"얼른 출발합시다. 유재현 씨.\"");
            Print("\"어이구, 잠깐만요. 형사님.\"");
            Print("\"예?\"");
            Print("\"온 김에 뭐라도 사가야지~");
            Print("둘러보고 뭐라도 사고 가요. 후회 안 할 거예요~\"");
            Print("\"아...\"\n");
            Print("김민중 씨가 곤란하다는 듯이 나를 힐끗 쳐다보았다.");
            Print("그래, 나보고 결정하라는 거겠지.\n");
        }
        public override void Choice()
        {
            Console.WriteLine("");
            Console.WriteLine("1. 샤프를 산다.");
            Console.WriteLine("2. 우산을 산다.");
            Console.WriteLine("3. 아무 것도 사지 않는다.");
            if (Game.Player.observation >= 5)
            {
                for (int i = 0; i < inventory.items.Count; i++)
                {
                    if (inventory.items[i] == "usb")
                    Console.WriteLine("4. 매장을 둘러본다.");
                }
            }
            Console.ReadKey(true);
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Game.Player.gold -= 1000;
                    inventory.Add("샤프");
                    Print("샤프를 구매했습니다.");
                    Print("1000원이 차감되었습니다.");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Game.Player.gold -= 6000;
                    inventory.Add("우산");
                    Print("우산을 구매했습니다.");
                    Print("6000원이 차감되었습니다.");
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Print("아무 것도 구매하지 않았습니다.");
                    Print("밖으로 이동합니다.");
                    break;

            }
        }
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Game.ChangeScene("BlueTownScene1");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Game.ChangeScene("BlueTownScene1");
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Game.ChangeScene("BlueTownScene1");
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Game.ChangeScene("BlueTownEvidence1");
                    break;
            }
        }
    }
    public class BlueTownSceneEvidence1 : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("\"어?\"\n");
            Print("매장을 둘러보던 내 눈에 띄인 건 초소형 빔프로젝터였다.\n");
            Print("\"사장님 이거 설마 빔프로젝터에요?\"");
            Print("\"눈썰미가 좋네~ 근데 빔프로젝터는 어니고 영상 재생기에요.");
            Print("그거 이번에 휴대형으로 나온 거라 쓰려면 usb같은 거 있어야 해서 별로 쓸모는 없을 건디?\"\n");
            Print("이거다. 이게 지금 내게 딱 필요한 거다.");
            Print("게다가 마침 내게는 확인이 필요한 usb도 있지 얺은가.");
            Print("\"사장님 저 이걸로 할게요.\"\n");
            Print("영상재생기를 구매했습니다.");
            Print("10000원이 차감되었습니다.");

        }
        public override void Choice()
        {
            Console.WriteLine("");
            Console.WriteLine("▶ 다음 페이지로 넘어가려면 아무 키나 눌러주세요");
            Console.ReadKey(true);
        }
        public override void Result() {
            Game.Player.gold -= 10000;
            inventory.Add("영상재생기");
        }
        public override void Next()
        {
            Game.ChangeScene("BlueTownEvidence2");
        }
    }
    public class BlueTownSceneEvidence2 : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("나는 영상재생기를 조심스럽게 챙긴 뒤 조수석 문 앞에 서서 말했다.\n");
            Print("\"형사님, 정말 죄송한데 운전 한 번만 부탁드려도 될까요?\"");
            Print("\"예, 알겠습니다. 편하게 보십시오.\"");
            Print("\"감사합니다.\"\n");
            Print("긴장되는 마음을 달려며 떨리는 손으로 재생기에 usb를 꽂았다.");
            Print("화면에 천천히 빛이 들어오는 듯 하더니 영상을 자동으로 재생하기 시작했다.\n");
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
            Game.ChangeScene("BlueTownUSB");
        }
    }
    public class BlueTownSceneUSB : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("지지직\n");
            Print("김민중 씨 말대로 소리가 제대로 녹음이 되어있지는 않았으나,");
            Print("중간중간 싸우는 듯한 제스쳐가 보였다.\n");
            Print("\'나는 네가!! 부모님한테... 척... 그런... 싫었어...!\'\n");
            Print("어린 은오가 어린 은우에게 악을 쓰며 소리를 지른다.");
            Print("내 앞에서는 한 번도 싸운 적이 없었던 아이들이었다.");
            Print("\"... 소리를 조금 더 키울 수 있으면 좋았을텐데.\"\n");
            Print("그러나 기기에 따로 음향 조절 버튼은 없없다.");
            Print("화면 속에서 은오는 악에 받친 듯 계속 소리를 지르고 있었고");
            Print("은우는 묵묵히 그런 은오를 담담히 바라보고 있었다.");
            Print("그러던 중 소리가 선명히 들리는 부분이 있었다.\n");
            Print("\'누가 너한테 그런 짓 해 달라고 했어?!");
            Print("왜, 왜 그렇게까지 해서 네가...!\'\n");
            Print("그 말을 끝으로 어린 은오는 무너져내리듯이 바닥에 주저앉아 울기 시작했고");
            Print("어린 은우는 그런 은오를 뒤로 한 채 어딘가로 발걸음을 옮기며 영상은 끝이 났다.\n");
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
            Game.ChangeScene("BlueTownUSB1");
        }
    }
    public class BlueTownSceneUSB1 : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("\"이게... 무슨,\"");
            Print("\"유재현 씨가 보시기에는 어떻습니까?\"\n");
            Print("내가 영상을 끝까지 보고나니 잠자코 있던 김민중 씨가 물었다.\n");
            Print("\"말씀드렸다시피 저는 유재현 씨네 가족 분들의 사정은 잘 모릅니다.");
            Print("하지만 어린 아이가 저렇게 악을 쓰며 소리를 지른다는 건 흔한 일은 아닙니다.");
            Print("무언가 유은오 씨를 저렇게 만든 이유가 있겠지요.\"\n");
            Print("신호가 빨간불로 바뀌는 걸 확인한 김민중 씨가 내 눈을 똑바로 마주치며 말한다.\n");
            Print("\"무엇이 어린 동생들을 저렇게 만들었는지 짐작가는게 정말 없냐고 묻는 겁니다.\"\n");
            Print("나는 할 수 있는 말이 없었다.\n");
            Print("\"저는... 아이들의 진짜 보호자가 될 수 없습니다.\"\n");
            Print("나는 묵묵히 말을 내뱉었고, 김민중 씨는 담담히 내 이야기를 들어주었다.\n");
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
            Game.ChangeScene("BlueTownUSB2");
        }
    }
    public class BlueTownSceneUSB2 : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("\"저희는 사실 피를 나눈 형제들은 아닙니다.");
            Print("저, 어렸을 때부터 부모님의 학대 속에서 자랐거든요.");
            Print("그 사람들의 기대에 미치지 못했던 저는 중학생 때 집을 나와서 혼자 살았어요.");
            Print("그래도 꼴에 자식이라고 생활비는 꼬박꼬박 보내주더라구요.");
            Print("물론 쓰기 싫어서 안 쓰고 모아뒀고요.\"\n");
            Print("그래, 그 사람들이 그랬던 적도 있었지.");
            Print("살면서 단 한 번도 부모님이 좋았던 적은 없었다.");
            Print("나한테는 남이나 마찬가지인 사람들이었으니까.");
            Print("\"은오랑 은우는요. 저를 대신하려고 입양해 온 애들이었어요.");
            Print("부모님의 트로피가 되지 못한 나를 대신해 트로피로 키우려던 아이들.");
            Print("그래서 좀 부끄럽지만 애들이 어렸을 때 집에 무슨 일이 있었는지 잘 모르겠어요.");
            Print("어렸을 적 가끔 봤던 애들은 정말 착하고 똘똘했었거든요.");
            Print("나와는 다르게 사랑을 받으면서 자라는 것 같아보여서 다행이라고 생각했었어요.");
            Print("이렇게 어린애들마저 손대지는 않는 것 같아서 나름 안심도 했었죠.");
            Print("그낭 그게 다에요. 저는 저랑 같이 산 이후의 애들밖에는 몰라요.\"\n");
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
            Game.ChangeScene("BlueTownUSB3");
        }
    }
    public class BlueTownSceneUSB3 : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("\"... 그렇군요. 그럼 확실히 두 사람을 찾아야 실마리가 풀리겠네요.\"\n");
            Print("김민중 씨는 누언가를 골똘히 생각하더니 입을 열었다.\n");
            Print("\"그럼 질문을 바꾸겠습니다.");
            Print("동생 분들을 찾게 되면 잘 타일러서 데려올 수 있겠습니까?\"");
            Print("\"네?\"");
            Print("\"저는 아직 잘모르겠습니다.");
            Print("아무래도 아직 어린 학생이다보니 다른 사람들한테 알리기도 좀 그랬고요.");
            Print("그래도 되도록이면 진실이 어떻든 간에 유은우 씨에게 피해가 생기지 않았으면 좋겠습니다.");
            Print("형사가 이런 말 하는 건 좀 그렇긴 한데.\"\n");
            Print("김민중 씨가 씨익 웃으며 말했다.\n");
            Print("\"우리 선에서 해결 할 수 있는 일이면 덮은 채 넘어가고 싶습니다.\"");
            Print("\"형사님...\"");
            Print("\"사실 저도 어린 동생이 있습니다.");
            Print("제가 워낙 바쁘다보니 유재현 씨 일이 그닥 남일같지는 않아서 말입니다.\"");
            Print("\"감사, 감사합니다... 정말 감사합니다...\"");
            Print("\"울지 마십시오. 저희는 어른이잖습니까.");
            Print("어린아이를 보호하고 지키는 게 저희 의무아니겠습니까?\"");
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
            Game.ChangeScene("BlueGreenMountain");
        }
    }
    public class BlueTownScene1 : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("그렇게 문구점 밖으로 나온 우리는 서둘러 청록산으로 향했다.");
            Print("조금만 있으면 애들을 만날 수 있어.\n");
            Print("\"빠르게 출발합시다. 시간이 얼마 안 남았어요.\"\n");
            Print("애들이 청록산에는 왜 간 걸까. 정말 하나도 모르겠다.");
            Print("거기서 8시에 해야만 한다는 일이 대체 뭐길래 이렇게 날 불안하게 만드는 걸까.");
            Print("정말 미치기 일보 직전인 것만 같았다.\n");

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
            Game.ChangeScene("BlueGreenMountain");
        }
    }

}
