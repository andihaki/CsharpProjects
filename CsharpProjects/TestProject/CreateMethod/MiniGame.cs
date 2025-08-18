using System;
using System.Globalization;

namespace TestProject.CreateMethod;

class MiniGame
{
    public static void Run()
    {
        // US dot decimal separator
        // CultureInfo.CurrentCulture = new CultureInfo("en-US");
        Planner();
    }

    public static void Planner()
    {
        Random random = new Random();
        Console.CursorVisible = false;
        int height = Console.WindowHeight - 1;
        int width = Console.WindowWidth - 5;
        bool shouldExit = false;
        int speed = 1;

        // Console position of the player
        int playerX = 0;
        int playerY = 0;

        // Console position of the food
        int foodX = 0;
        int foodY = 0;

        // Available player and food strings
        string[] states = ["('-')", "(^-^)", "(X_X)"];
        string[] foods = ["@@@@@", "$$$$$", "#####"];

        // Current player string displayed in the Console
        string player = states[0];

        // Index of the current food
        int food = 0;

        InitializeGame();
        while (!shouldExit)
        {
            if (TerminalResized())
            {
                Console.WriteLine("\rConsole was resized. Program exiting.");
                break;
            }
            if (foodX == playerX && foodY == playerY)
            {
                ChangePlayer();
                ShowFood();
                if (player == "(X_X)")
                {
                    FreezePlayer();
                }
                else if (player == "(^-^)")
                {
                    speed = 3;
                }
                else if (player == "('-')")
                {
                    speed = 1;
                }
            }
            Move();
        }

        // Returns true if the Terminal was resized 
        bool TerminalResized()
        {
            return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
        }

        // Displays random food at a random location
        void ShowFood()
        {
            // Update food to a random index
            food = random.Next(0, foods.Length);

            // Update food position to a random location
            foodX = random.Next(0, width - player.Length);
            foodY = random.Next(0, height - 1);

            // Display the food at the location
            Console.SetCursorPosition(foodX, foodY);
            Console.Write(foods[food]);
        }

        // Changes the player to match the food consumed
        void ChangePlayer()
        {
            player = states[food];
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(player);
        }

        // Temporarily stops the player from moving
        void FreezePlayer()
        {
            Thread.Sleep(1000);
            player = states[0];
        }

        // Reads directional input from the Console and moves the player
        void Move()
        {
            int lastX = playerX;
            int lastY = playerY;

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    playerY--;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    playerY++;
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    playerX -= speed;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    playerX += speed;
                    break;
                case ConsoleKey.Escape:
                default:
                    shouldExit = true;
                    break;
            }

            // Clear the characters at the previous position
            Console.SetCursorPosition(lastX, lastY);
            for (int i = 0; i < player.Length; i++)
            {
                Console.Write(" ");
            }

            // Keep player position within the bounds of the Terminal window
            playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
            playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

            // Draw the player at the new location
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(player);
        }

        // Clears the console, displays the food and player
        void InitializeGame()
        {
            Console.Clear();
            ShowFood();
            Console.SetCursorPosition(0, 0);
            Console.Write(player);
        }
    }
}