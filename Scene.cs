using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public override void Next()
        {
            // 씬 전환
        }

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
    }
}
