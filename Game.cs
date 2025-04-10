using NewProject_CS.Scene_Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static NewProject_CS.Scene_Add.PrologScene;

namespace NewProject_CS
{
    public static class Game
    {
        private static bool gameOver;
        
        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;

        private static Player player;
        public static Player Player { get { return player; } }
        public static void Start()
        {
            // 게임에 있는 모든 씬들을 보관하고 빠르게 찾아줄 용도로 쓸 자료구조
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Prolog", new PrologScene());
            sceneDic.Add("Prolog1", new PrologScene1());
            sceneDic.Add("Prolog2", new PrologScene2());
            sceneDic.Add("Prolog3", new PrologScene3());
            sceneDic.Add("Prolog4", new PrologScene4());
            sceneDic.Add("ImprisonedEnd1", new ImprisonedEndScene1());
            sceneDic.Add("ImprisonedEnd2", new ImprisonedEndScene2());
            sceneDic.Add("ChapterOne", new ChapterOneScene());
            sceneDic.Add("ChapterOne1", new ChapterOneScene1());
            sceneDic.Add("ChapterOne2", new ChapterOneScene2());
            sceneDic.Add("ChapterOne3", new ChapterOneScene3());
            sceneDic.Add("DeadEnd", new DeadEndScene());
            sceneDic.Add("BlueTown", new BlueTownScene());
            sceneDic.Add("BlueTownShop", new BlueTownSceneShop());
            sceneDic.Add("BlueTownEvidence", new BlueTownSceneEvidence());
            
            curScene = sceneDic["Title"];

            player = new Player();
            player.observation = 2;
            player.gold = 10000;
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
                curScene.Next();
            }
        }

        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }
        public static void Gameover(string ending)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(ending);

            gameOver = true;
        }

    }

}
