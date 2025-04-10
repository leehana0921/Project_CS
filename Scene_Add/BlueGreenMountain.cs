using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_CS.Scene_Add
{
    public class BlueGreenMountainScene : Scene
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
