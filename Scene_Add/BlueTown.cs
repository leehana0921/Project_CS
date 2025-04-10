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
            Print("애들이 청록산에는 왜 간 걸까.");
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
