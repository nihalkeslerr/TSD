using NClap.Metadata;

namespace TSD.Akka.Commands
{
    enum CommandList
    {
        [Command(typeof(PopulationCommand), LongName = "population", Description = "Creates some people")]
        CreatePopulation,

        [Command(typeof(InfectCommand), LongName = "infect", Description = "Infects a random person")]
        InfectSomebody,

        [Command(typeof(ZombieCommand), LongName = "zombie", Description = "Transforms a random person to the ZOMBIE")]
        ZombieSomebody,

        [Command(typeof(ForwardCommand), LongName = "forward", Description = "Start a next day, people are meeting people")]
        Forward,

        [Command(typeof(StatsCommand), LongName = "stats", Description = "Show statistics for today")]
        Stats,

        [Command(typeof(ExitCommand), LongName = "exit", Description = "Exits the application")]
        Exit,

        [HelpCommand(LongName = "help", Description = "Help for the applications (you are reading it now)")]
        Help
    }
}
