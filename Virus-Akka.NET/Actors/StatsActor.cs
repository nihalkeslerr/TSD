using System;
using Akka.Actor;
using Akka.Event;

namespace TSD.Akka.Actors
{
    public class StatsAskMessage { }

    public class StatsReplyMessage
    {
        public int Infected { get; }
        public int Uninfected { get; }
        public int Zombied { get; }
        public StatsReplyMessage(int infected, int zombied, int uninfected) {
            Infected = infected;
            Zombied = zombied;
            Uninfected = uninfected;

        }
    }

    public class StatsActor : ReceiveActor
    {
        public int Infected { get; set; }
        public int Uninfected { get; set; }
        public int Zombied { get; set; }

        public StatsActor()
        {
            Receive<PersonActor.InfectedMessage>(message => Infected++);

            Receive<PersonActor.ZombiedMessage>(message => { Zombied++; Uninfected--;  });
            Receive<StatsAskMessage>(message => Sender.Tell(new StatsReplyMessage(Infected, Zombied, Uninfected), Self));
        }
    }
}
