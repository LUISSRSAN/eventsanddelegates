using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eventsanddelegates
{
    public class RenderingEngine
    {
        private void StartGame(){
            Console.WriteLine("Rendering Engine Started");
            Console.WriteLine("Drawing Visuals");
        }
        private void GameOver(){
            Console.WriteLine("Rendering Engine Stopped");
        }

    }
}