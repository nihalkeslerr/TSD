﻿using System.Threading;
using System.Threading.Tasks;
using Akka.Actor;
using NClap.Metadata;
using TSD.Akka.Actors;

namespace TSD.Akka.Commands
{
    class ForwardCommand : Command
    {
        public ActorSystem System { get; }

        public ForwardCommand(ActorSystem system) => System = system;

        public override Task<CommandResult> ExecuteAsync(CancellationToken cancel)
        {
            var people = System.ActorSelection($"user/{ActorNames.People}/*");
            people.Tell(new PersonActor.StartDayMessage("Brand new day"));

            return Task.FromResult(CommandResult.Success);
        }
    }
}
