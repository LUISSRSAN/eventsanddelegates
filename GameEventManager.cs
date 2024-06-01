using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eventsanddelegates
{
    public class GameEventManager
    {
        public delegate void GameEvent();
        public static GameEvent OnGameStart,OnGameOver;
public static void TriggerGameStart(){
    if(OnGameStart != null){
        Console.WriteLine("The game has started ...");
        OnGameStart();
    }
}


    }
}