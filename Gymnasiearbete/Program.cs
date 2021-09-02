using System;
using Raylib_cs;

namespace Gymnasiearbete
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1920, 1000, "Prototyp GYARTE");
            Raylib.SetTargetFPS(30);

            int startBlinkFrame = 0;
            int duration = 1 * 30;
            int loopTime = 5 * 30;

            //TARGET VALUES
            int targetDiameter = 100;
            int

            Random r = new Random();

            int frameCount = 0;

            Shoot circle = new Shoot();
            circle.x = 0;


            while (!Raylib.WindowShouldClose())
            {
                frameCount++;
                if (frameCount == loopTime)
                {
                    startBlinkFrame = r.Next(loopTime - duration);
                    frameCount = 0;
                }



                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.WHITE);

                if (frameCount >= startBlinkFrame && frameCount <= startBlinkFrame + duration)
                {
                    Raylib.DrawCircle(500, 500, 100, Color.RED);
                }

                Raylib.EndDrawing();
            }
        }
    }
}
