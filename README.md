# this project is kinda abandoned, sorry. maybe some day i will have motivation to update it to raylib-cs 5.0.0

![epic library logo trust me its very epic](https://raw.githubusercontent.com/danilwhale/Raylib-cs.Extensions/main/Assets/Logo.png)
[![Nuget](https://img.shields.io/nuget/v/Raylib-cs.Extensions)](https://www.nuget.org/packages/Raylib-cs.Extensions)

# Raylib-cs.Extensions
## attempt to make oop using extensions on top of raylib-cs
### wip!!1
todo:
- port examples

~~there's also Raylib-cs.Extensions.Game project to test things i made~~

there's `Raylib-cs.Extensions.Examples` project with some of raylib examples ported.
FeatureTest is `Raylib-cs.Extensions.Game`'s Program class, it won't be updated anymore :(

---

## installation
### embedded
1. install Raylib-cs package
2. download source code
3. unpack `Raylib_cs.Extensions` folder to your project folder

### nuget package 
#### dotnet cli
```
dotnet install Raylib-cs.Extensions
```

#### visual studio
1. `Project` > `Manage NuGet Packages`
2. enter `Raylib-cs.Extensions` in search bar
3. select package
4. click `[ Install ]`

#### rider
1. triple line in title bar (Alt + \)
2. `Tools` > `NuGet` > `Show NuGet Packages`
3. enter `Raylib-cs.Extensions` in search bar
4. select package
5. click on green + on right side

---

## hello world window
```cs
using Raylib_cs;
using static Raylib_cs.Raylib;
using Raylib_cs.Extensions;

InitWindow(800, 480, "hello world!");
SetTargetFPS(60);

while (!WindowShouldClose)
{
  BeginDrawing();
  Color.WHITE.ClearBackground();

  Color.BLACK.DrawText("hello world" 12, 12, 20);

  EndDrawing();
}

CloseWindow();
```
