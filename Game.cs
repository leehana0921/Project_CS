using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_CS
{
    public static class Game
    {
        private static bool gameOver;

        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;

        public static void Start()
        {
            // 게임에 있는 모든 씬들을 보관하고 빠르게 찾아줄 용도로 쓸 자료구조
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());

            curScene = sceneDic["Title"];
        }

        public static void End()
        {

        }

        public static void Run()
        {
            while (gameOver == false)
            {
                curScene.Render();
                curScene.Choice();
                curScene.Input();
                curScene.Result();
                curScene.Wait();
                curScene.Next();
            }
        }

    }
}
