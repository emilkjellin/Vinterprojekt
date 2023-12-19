using System.Numerics;
using Raylib_cs;
using System.Reflection.Metadata;
using System.Security.Principal;
using System;
using System.Media;
Raylib.InitWindow(1920 ,1080, "");
Raylib.SetTargetFPS(60);
int x = 400;
int y = 300;
Texture2D Batman = Raylib.LoadTexture("BATMAN2.png");
Texture2D jumpscare = Raylib.LoadTexture("baba.png");
Texture2D menu = Raylib.LoadTexture("OIP.png");
Sound sound = Raylib.LoadSound("");
Batman.Height = 50;
Batman.Width = 50;
jumpscare.Height = 1080;
jumpscare.Width = 1920;
menu.Height = 1080;
menu.Width = 1920;

 int jumpscare1 = 0;

 int game = 0;


while (!Raylib.WindowShouldClose())
{
if (game == 1)
{
/*Keybinds*/
if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
 {
 x -= 10;
 }

if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
 {
 x += 10;
 }

 
if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
 {
 y -= 10;
 }


if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
 {
 y += 10;
 }

if (jumpscare1 == 1)
{
    if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
    {
        x = 700;
        y = 600;
        jumpscare1 = 0;
    }

 if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
 {
    game = 0;
 }
}
/*Collisions*/
if ( x < 0 )
{
    x = 0;
}

if ( x > 1920 )
{
x = 1920;
}

if (y < 0 )
{
    y = 0;
}

if ( y >1080)
{
    y = 1080;
}

if ( x > 400 && x < 600 && y > 300 && y <500)
{
 x = 500;
 y = 400;
}

if ( x > 400 && x < 600 && y > 300 && y <500)
{
 jumpscare1 = 1;
}


Raylib.BeginDrawing();


    Raylib.ClearBackground(Color.PURPLE);


    Raylib.DrawTexture(Batman, x-25, y, Color.WHITE);

    if ( jumpscare1 == 1)
    {
        Raylib.DrawTexture(jumpscare, 0, 0, Color.WHITE);
        Raylib.DrawText("Press Enter to restart ", 400, 540, 100,Color.WHITE);
        Raylib.DrawText("Press Space to return to menu ", 200, 740, 100,Color.WHITE);
    }

    if ( jumpscare1 == 0)
        Raylib.DrawRectangle( 400, 320, 200, 200, Color.BLACK);

Raylib.EndDrawing();


}
if (game == 0)
{
    Raylib.BeginDrawing();
       
        Raylib.DrawTexture(menu, 0, 0, Color.WHITE);
        Raylib.DrawText("Press Enter to start ", 400, 540, 100,Color.WHITE);
    Raylib.EndDrawing();

    if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
 {
  game = 1;
 }
}
/*Ljud*/

if (jumpscare1 == 1)
{
 /*Raylib.PlaySound();*/
}
}