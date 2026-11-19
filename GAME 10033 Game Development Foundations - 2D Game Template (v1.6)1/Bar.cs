using System;
using System.Numerics;
namespace MohawkGame2D;

public class Bar
{
    Vector2 position = new Vector2(100, 300);

    float speed = 5;

    public void Update()
    {
        //move left
        if (Input.IsKeyboardKeyDown(KeyboardKey.Left))
        {
            position.X -= 5;
        }

        //move right
        if (Input.IsKeyboardKeyDown(KeyboardKey.Right))
        {
            position.X += 5;
        }


    }
    

    public void DrawBar()
    {
        Draw.SetFillColor(255, 0, 0);
        Draw.Rectangle(position.X,position.Y, 100, 20);
    }
}
