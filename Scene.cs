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

        public override void Result() 
        { 

        }

        public override void Choice()
        {
            Console.WriteLine("");
            Console.WriteLine("게임 시작을 위해 아무 키나 눌러주세요.");
            Console.ReadKey(true);
        }

        public override void Wait() 
        { 

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
            Print("평범하다면 평범 할 수 있는 가장인 나는 \n");
            Print("고등학생 때 화재로 부모님을 잃고 쌍둥이 동생 둘과 같이 살고 있었다.\n");
            Print("그렇게 평소와 다름없이 일을 하던 중 회사로 걸려 온 한 통의 전화,\n");
            Print("갑자기 걸려 온 한 통의 전화는 내 인생을 송두리째 바꿔놓기에는 충분했다.\n");

        }

        public override void Result()
        {

        }

        public override void Choice()
        {
            Console.WriteLine("");
            Console.WriteLine("▶ 다음 페이지로 넘어가려면 아무 키나 눌러주세요");
            Console.ReadKey(true);
        }

        public override void Wait()
        {

        }

        public override void Next()
        {
            Game.ChangeScene("");
        }
    }
}
