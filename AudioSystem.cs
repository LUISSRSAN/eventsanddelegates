using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eventsanddelegates
{
    public class AudioSystem
    {

        public AudioSystem(){
        GameEventManager.OnGameStart +=StartGame;
        GameEventManager.OnGameOver +=GameOver;
    }


        private void StartGame(){
            Console.WriteLine("Audio System Started...");
            Console.WriteLine("Playing Audio...");
        }
        private void GameOver(){
            Console.WriteLine("Audio System Stopped");
        }
    }
}