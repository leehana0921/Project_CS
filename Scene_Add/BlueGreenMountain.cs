namespace NewProject_CS.Scene_Add
{
    public class BlueGreenMountainScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("\"도착했습니다. 여기가 청록산입니다.\"");
            Print("여기서 팔각정까지 40분정도 걸린다고 하니 서둘러서 가시죠.\"\n");
            Print("평일임에도 불구하고 사람은 꽤나 많은 편이었지만");
            Print("해가 지고 있어서 그런지 다들 하산하는 분위기였다.");
            Print("등산로 초입에 다다랐을 즈음 갑자기 소나기까지 내리기 시작했다.");
            Print("내리는 소나기를 온 몸으로 받아내며 오르다보니 멀리서 팔각정이 보이기 시작했다.\n");
            Print("\"거의 다 도착한 것 같습니다! 앞에 팔각정같이 생긴 게 보여요!\"\n");
            Print("점점 거세지는 빗물이 얼굴을 따라 흐르니 앞이 뿌얘 잘 보이지 않았다.");
            Print("팔각정이 점점 가까워지고, 그 안에서 두 인영이 서성이는 게 보였다.");
            Print("나는 서성이는 두 인영에게 있는 힘껏 소리를 지르며 달려갔다.\n");
            Print("\"은우야! 은오야! 형이야! 형이 왔어!!\"\n");
            Print("내가 미친 척 달려가니 두 인영은 멈칫하더니 내 쪽으로 눈을 돌렸다.\n");
            Print("\"형...?\"");
            Print("\"형이 왜 여기에 있어?\"");
            Print("\"대체 여기서 뭘 하고 있었던 거야? 형이 얼마나 걱정한 줄 알아?!\"\n");
            Print("동생들은 화를 내는 나를 잠시 보더니 이내 서로 눈을 마주쳤다.\n");

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
            Game.ChangeScene("BlueGreenMountain1");
        }
    }
    public class BlueGreenMountainScene1 : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("\"형. 미안해. 그런데 우리한테는 이게 최선이야.\"\n");
            Print("은우가 챙겨온 가방을 조심스레 내려놓더니 조심스레 지퍼를 열었다.");
            Print("가방 안에는 잘린 색종이로 가득 차있었고 자세히 보니 같은 가방이 여러 개 더 있었다.\n");
            Print("\"이게 무슨...\"");
            Print("\"형. 솔직히 마지막에 형 얼굴 봐서 너무 좋긴 한데 형은 우리랑 같이 못가.\"");
            Print("\"마지막이라니, 은우야. 그게 무슨 소리야, 응?");
            Print("형이 알아들을 수 있게 말 해 줘야지... 은우야... 은오야...!\"\n");
            Print("허탈감에 무너지는 내 몸을 김민중 씨가 받아주었다.");
            Print("지금 이게 무슨 상황인지 전혀 알 수가 없었다.");
            Print("그렇게 착하고 말 잘 듣던 동생들이 왜 이렇게 된 건지, 전혀 알 수가 없었다.\n");
            Print("\"유은우 씨.\"");
            Print("\"형사님. 형사님이라면 역시 형한테 찾아가실 줄 알았어요.\"\n");
            Print("형이랑 여기까지 온 건 의외였지만.");
            Print("그렇게 말 하며 살풋 웃는 은우는 내가 알던 은우가 아닌 것 같았다.");
        }
        public override void Choice()
        {
            Console.WriteLine("");
            Console.WriteLine("▶ 사용 할 아이템을 선택해주세요");
            if (inventory != null)
            {
                for (int i = 0; i < inventory.items.Count; i++)
                {
                    if (inventory.items[i] == "샤프")
                        Console.WriteLine("1. 샤프를 사용한다");
                }
                for (int i = 0; i < inventory.items.Count; i++)
                {
                    if (inventory.items[i] == "우산")
                        Console.WriteLine("2. 우산을 사용한다");
                }
                for (int i = 0; i < inventory.items.Count; i++)
                {
                    if (inventory.items[i] == "usb")
                        Console.WriteLine("3. usb를 사용한다");
                }
            }
            else
            {
                Console.WriteLine("현재 사용 할 수 있는 아이템이 없습니다");
                Console.WriteLine("a 키를 눌러주세요");
            }
            Console.ReadKey(true);
        }
        public override void Result() { }
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Game.ChangeScene("SharpEnd");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Game.ChangeScene("UmbrellaEnd");
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Game.ChangeScene("USBEnd");
                    break;
                case ConsoleKey.A:
                    Game.ChangeScene("FamilyDeadEnd");
                    break;
            }
        }
    }
    public class FamilyDeadEndScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");
            Print("\"비가 온 건 예상 밖이였지만 이정도면 우리 계획에 지장은 없을 것 같은데.\"\n");
            Print("은오는 그렇게 말 하며 가방을 열어 색종이를 전부 쏟기 시작했다.");
            Print("그 후 생수병을 하나 꺼내서 그 위에 붓는데 물 색깔이 이상했다.");
            Print("물을 쏟던 은오는 눈을 살짝 들어 나와 마주보더니 굳은 표정으로 입을 열었다.\n");
            Print("\"형. 있잖아. 우리는 이 팔각정이 정말 싫어.");
            Print("형은 몰랐겠지만 여긴 부모님이 우리를 데리고 가장 많이 왔던 곳이거든.");
            Print("특히 이 팔각정은 절벽 바로 위에 있어서 여기서 내려다보면 꽤 무서워.");
            Print("나는 높은 곳이 정말 싫었는데 이 팔각정때문에 더 싫어지더라.\"\n");
            Print("은오는 숨을 한 번 고르더니 말을 이었다.\n");
            Print("\"항상 날 이 난간 위에 올려두고 귀에 속삭이셨어.");
            Print("다른 사람들에게는 안들리게.");
            Print("그저 아들이 원해서 올려주긴 했는데 떨어지지 않게 붙잡고 있는 자상한 아버지인 것마냥.");
            Print("아버지는 언제든 날 이 곳에서 떨어트릴 수 있다고 하셨어.");
            Print("죽고 싶지 않으면 그 누구보다 열심히 하라고.");
            Print("우리가 그 누구보다 우수해야만 살아갈 가치가 생긴다고 입이 닳도록 말했어.\"\n");
            Print("색종이 위에 액체를 다 뿌린 은오는 나를 똑바로 보며 말했다.");
            Print("\"난 세상에서 이 팔각정이 제일 싫어, 형.\"\n");
            Print("아, 그랬구나. 그저 내가 모르고 있을 뿐이었구나.");
            Print("그 사람들이 애들을 잘 키운 게 아니라 그냥 겁 먹은 애들이 어떻게든 살려고 발버둥쳤던 거였구나.");
            Print("");
            Print("");
            Print("");
            Print("");
            Print("");
            Print("");

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
            Game.ChangeScene("BlueGreenMountain1");
        }
    }
    public class SharpEndScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");


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
            Game.ChangeScene("BlueGreenMountain1");
        }
    }
    public class UmbrellaEndScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");


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
            Game.ChangeScene("BlueGreenMountain1");
        }
    }
    public class USBEndScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("");


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
            Game.ChangeScene("BlueGreenMountain1");
        }
    }

}
