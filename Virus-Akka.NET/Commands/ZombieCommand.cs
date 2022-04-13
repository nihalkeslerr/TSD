using System.Threading;
using System.Threading.Tasks;
using Akka.Actor;
using NClap.Metadata;
using TSD.Akka.Actors;

namespace TSD.Akka.Commands
{
    public class ZombieCommand : Command
    {
        public ActorSystem System { get; }

        public ZombieCommand(ActorSystem system) => System = system;

        public override Task<CommandResult> ExecuteAsync(CancellationToken cancel)
        {
            var randomPerson = System.ActorSelection($"user/{ActorNames.People}");
     
            randomPerson.Tell(new PersonActor.ZombiedMessage("Initial become of zombie."));

            return Task.FromResult(CommandResult.Success);
        }
    }
}
