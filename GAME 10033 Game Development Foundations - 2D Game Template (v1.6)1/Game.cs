using System;
using System.Numerics;

namespace MohawkGame2D;


    public class Game
    {
        Bar bar = new Bar();
        Ball ball = new Ball();
    public void Setup()
        {
            Window.SetSize(400, 400);
        }

        public void Update()
        {
            Window.ClearBackground(240);

            bar.Update();
            bar.DrawBar();
            ball.Update();
            ball.DrawBall();
        }
    }

