using System;
using DiscordRPC;
using DiscordRPC.Logging;

class Program
{
    // Example for discordRPC Made by Aapoxz
    // You can use this for anything you want. Please just add the code to your project, dont use this source for claiming as your own. 
    // I would love to get credits but not needed.

    // ------------------------------------------------------------------------------
    // DONT claim this project as your own. Use the code for your projects. Peace :3
    // ------------------------------------------------------------------------------

    private static DiscordRpcClient client;

    static void Main(string[] args)
    {
        Console.Title = "DiscordRPC - AX";
        Console.ForegroundColor = ConsoleColor.Blue;
   
        // Replace with ur id
        client = new DiscordRpcClient("1248600615010177044");
        Console.WriteLine("Welcome to AX-DiscordRPC\n");
        // Set the logger
        client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

        // Subscribe to events
        client.OnReady += (sender, e) =>
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("- RPC enabled.");
            Console.WriteLine("- RPC connected to {0} \n", e.User.Username);
        };

    

        // Connect to Discord
        client.Initialize();

        // Set the initial Rich Presence
        client.SetPresence(new RichPresence()
        {
            Details = "Coded by Aapoxz",
            State = "Example of discord rpc :)",
            Timestamps = Timestamps.Now,
       
        });

      
      
        Console.ReadKey(true);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Press any key to exit...");
        // Dispose of the client on exit
        client.Dispose();
    }
}
