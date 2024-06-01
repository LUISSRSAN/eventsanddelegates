using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eventsanddelegates
{
    public class Player
    {
        public string PlayerName { get; set; }
        public Player(string name){
            this.PlayerName = name;
        }



        private void StartGame(){
            Console.WriteLine($"Spawning Player with ID:{PlayerName
            }");
        }
        private void GameOver(){
            Console.WriteLine($"Removing Player with ID:{PlayerName}");
        }
    }
}