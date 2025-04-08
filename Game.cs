using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NewProject_CS.PrologScene;

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
            sceneDic.Add("Prolog", new PrologScene());
            sceneDic.Add("Prolog1", new PrologScene1());
            sceneDic.Add("Prolog2", new PrologScene2());
            sceneDic.Add("Prolog3", new PrologScene3());

            curScene = sceneDic["Title"];
        }

        public static void End()
        {

        }

        public static void Run()
        {
            while (gameOver == false)
            {
                Console.Clear();

                curScene.Render();
                Console.WriteLine();
                curScene.Choice();
                curScene.Input();
                Console.WriteLine();
                curScene.Result();
                Console.WriteLine();
                curScene.Wait();
                curScene.Next();
            }
        }

        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }
    }
}
