using System;
using System.Threading;
using System.Threading.Tasks;
using Akka.Actor;
using NClap.Metadata;
using TSD.Akka.Actors;

namespace TSD.Akka.Commands
{
    class StatsCommand : Command
    {
        public ActorSystem System { get; }

        public StatsCommand(ActorSystem system) => System = system;

        public override async Task<CommandResult> ExecuteAsync(CancellationToken cancel)
        {
            var stats = System.ActorSelection($"user/{ActorNames.Stats}");
            var stats_data = await stats.Ask<StatsReplyMessage>(new StatsAskMessage(), TimeSpan.FromSeconds(5));
            Console.WriteLine($"Infected people: {stats_data.Infected}");
            Console.WriteLine($"Zombied people: {stats_data.Zombied}");

            return CommandResult.Success;
        }
    }
}
