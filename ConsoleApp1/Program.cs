using System.Numerics;
using Raylib_cs;
using System.Reflection.Metadata;
using System.Security.Principal;
using System;
using System.Media;
using System.Reflection;
Raylib.InitWindow(1920 ,1080, "");
Raylib.InitAudioDevice();
Raylib.SetTargetFPS(60);

int x = 400;
int y = 300;
int rectanglex = 1150;
int rectangley = 310;
double timer = 0;
int velocityx = 5;
int menutext = 30;
rectanglex += 3;
Texture2D Batman = Raylib.LoadTexture("BATMAN2.png");
Texture2D jumpscare = Raylib.LoadTexture("baba.png");
Texture2D menu = Raylib.LoadTexture("batman meny.png");
Texture2D menubild = Raylib.LoadTexture("Batmandope.png");
Texture2D joker = Raylib.LoadTexture("Joker.png");
Sound sound = Raylib.LoadSound("yt1s.com_-_last_christmas__sped_up[1].wav");
Sound menusound = Raylib.LoadSound("yt1s.com_-_Earrape_Scream__Sound_Effect[1].wav");

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
        x = 400;
        y = 300;
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

if ( jumpscare1 == 1)
{
 x = 400;
 y = 300;
}

if ( x > 300 && x < 705 && y > 350 && y <550)
{
 jumpscare1 = 1;
}
if ( x > 700 && x < 900 && y > 160 && y <580)
{
 jumpscare1 = 1;
}
if ( x > 250 && x < 650 && y > 100 && y <290)
{
 jumpscare1 = 1;
}
if ( x > 600 && x < 1000 && y > 0 && y <120)
{
 jumpscare1 = 1;
}
if ( x > 950 && x < 1150 && y > 0 && y <380)
{
 jumpscare1 = 1;
}
if ( x > 900 && x < 1700 && y > 435 && y <630)
{
 jumpscare1 = 1;
}
if ( x > 1100 && x < 1900 && y > 100 && y <280)
{
 jumpscare1 = 1;
}

if ( x > 1800 && x < 2000 && y > 100 && y <900)
{
 jumpscare1 = 1;
}

if (x > 200 && x < 250 && y > 800 && y < 900)
{
game = 2;
x = 250;
y = 850;
}
if (x > 0 && x < 300 && y > 100 && y < 580 )
{
    jumpscare1 = 1;
}
if (rectanglex +30 < x && rectanglex -30> x && y > 310 && y < 360)

{
    jumpscare1 = 1;
}
/*Rörelser*/

rectanglex += velocityx;
if (rectanglex >= 1800)
{
    velocityx *= -1;

}
if ( rectanglex <= 1150)
{
velocityx += 1;
}

/* Timer */
double untime = timer;  
if (game == 1)
{
    timer += 0.01;
}
if (game == 0 || game == 2)
{
    timer -= untime;
}
if (jumpscare1 == 1)
{
    timer -= untime;
}


Raylib.BeginDrawing();



    static void title()
    {
    Raylib.DrawText("Batman: burtham city", 600, 50, 50, Color.WHITE);
    }


    Raylib.ClearBackground(Color.PURPLE);
    
    Raylib.DrawTexture(joker, 200, 800, Color.WHITE);
    Raylib.DrawTexture(Batman, x-25, y, Color.WHITE);
    Raylib.DrawText($"Time: {timer}  ", 25, 45, 50, Color.WHITE);
    if ( jumpscare1 == 1)
    {
        Raylib.DrawTexture(jumpscare, 0, 0, Color.WHITE);
        Raylib.DrawText("Press Enter to restart ", 400, 540, 100,Color.WHITE);
        Raylib.DrawText("Press Space to return to menu ", 200, 740, 100,Color.WHITE);
        title();
    }


    if ( jumpscare1 == 0)
       {
        Raylib.DrawRectangle( 300, 0, 350, 200, Color.BLACK);
        Raylib.DrawRectangle( 0, 100, 300, 480, Color.BLACK);
        Raylib.DrawRectangle( 300, 380, 400, 200, Color.BLACK);
        Raylib.DrawRectangle(700, 180, 200, 400, Color.BLACK);
        Raylib.DrawRectangle(250, 100, 400, 200, Color.BLACK);
        Raylib.DrawRectangle(600, 0, 400, 140, Color.BLACK);
        Raylib.DrawRectangle(950, 0, 200, 400, Color.BLACK);
        Raylib.DrawRectangle(900, 450, 800, 200, Color.BLACK);
        Raylib.DrawRectangle(1100, 100, 800, 200, Color.BLACK);
        Raylib.DrawRectangle(1800, 100, 200, 800, Color.BLACK);

        /*Objekt i rörelse*/
        
        Raylib.DrawRectangle(rectanglex, rectangley, 20, 50, Color.BLACK);
       }




}
if (game == 0)
{
    Raylib.DrawTexture(menu, 0, 0, Color.WHITE);
    Raylib.DrawText("start", 900, 500, menutext,Color.WHITE);
    Raylib.DrawTexture(menubild , 650, -200, Color.WHITE);


 
    if (Raylib.GetMouseX() > 840 && Raylib.GetMouseX() < 1040 && Raylib.GetMouseY() > 450 && Raylib.GetMouseY() < 510)
    {
        
        

        if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
        {
            game = 1;
            x = 400;
            y = 300;
            jumpscare1 = 0;
        }
            
    }
      
}
if (game == 2)
{
    Raylib.ClearBackground(Color.BLACK);
   
    Raylib.DrawText("BATMAN CAPTURED JOKER!", 200, 540, 100, Color.WHITE);
    Raylib.DrawText("Enter (restart)",1650,1000,30,Color.WHITE);
    Raylib.DrawText("space (menu)",1400,1000,30,Color.WHITE);
     if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
     {
        game = 1;
        x = 400;
        y = 300;
     }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
        {
         game = 0;
         x = 400;
         y = 300;
        }
}


Raylib.EndDrawing();


/*Ljud*/

if (jumpscare1 == 1)
{
Raylib.PlaySound(sound);
}
if (game == 0)
{
    Raylib.PlaySound(menusound);
}

}
//unload
/*
Raylib.UnloadSound(sound);
Raylib.UnloadSound(menusound);

Raylib.CloseAudioDevice();
*/