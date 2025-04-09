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
            Print("");
            Print("고등학생 때 화재로 부모님을 잃고 쌍둥이 동생둘과 같이 살고 있었다.");
            Print("그렇게 평소와 다름없이 일을 하던 중 회사로 걸려 온 한 통의 전화,");
            Print("갑자기 걸려 온 한 통의 전화는 내 인생을 송두리째 바꿔놓기에는 충분했다.\n");
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
            Game.ChangeScene("BlueTown1");
        }
    }
}
