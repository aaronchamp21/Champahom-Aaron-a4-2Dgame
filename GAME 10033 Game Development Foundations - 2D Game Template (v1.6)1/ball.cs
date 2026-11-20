using System;
using System.Numerics;
namespace MohawkGame2D;


public class Ball
{
    Vector2 positon;

    float speed = 5;
    float radius = 10;

    int[] colors = new int[3];

    static System.Random random = new System.Random();
    public Ball()
    {
        positon = new Vector2(random.Next(0, 400), -20);
        RandomColor();
    }

    private void RandomColor()
    {
        colors[0] = random.Next(0, 255);
        colors[1] = random.Next(0, 255);
        colors[2] = random.Next(0, 255);
    }
    public void Update()
    {
        positon.Y += speed;
        if (positon.Y > 400)
        {
            positon.Y = -20;
            positon.X = random.Next(0, 400);
            RandomColor();
        }
    }
    public void DrawBall()
    {
        Draw.SetFillColor(colors[0], colors[1], colors[2]);
        Draw.Circle(positon.X, positon.Y, radius);
    }
}







