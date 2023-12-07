using System.Numerics;
using Raylib_cs;
using System.Reflection.Metadata;
Raylib.InitWindow(600 ,800, "");
Texture2D Batman = Raylib.LoadTexture("BATMAN2.png");
Batman.Height = 200;
Batman.Width = 200;
Raylib.SetTargetFPS(60);


int x = 400;
int y = 300;



while (!Raylib.WindowShouldClose())
{

Raylib.BeginDrawing();
Raylib.ClearBackground(Color.WHITE);
Raylib.DrawTexture(Batman, x, y, Color.WHITE);
Raylib.EndDrawing();

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

if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
 {

 
 }
}
