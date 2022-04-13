using System;
using Akka.Actor;
using Akka.Event;

namespace TSD.Akka.Actors
{
    class PersonActor : ReceiveActor
    {
        public class StartDayMessage
        {
            public string MessageText { get; }
            public StartDayMessage(string messageText) => MessageText = messageText;
        }

        public class ChatMessage
        {
            public string MessageText { get; }
            public ChatMessage(string messageText) => MessageText = messageText;
        }

        public class InfectedMessage
        {
            public string MessageText { get; }
            public InfectedMessage(string messageText) => MessageText = messageText;
        }
        public class ZombiedMessage
        {
            public string MessageText { get; }
            public ZombiedMessage(string messageText) => MessageText = messageText;
        }

        public enum PersonState
        {
            Uninfected,
            Infected,
            Zombied
        }

        private readonly ILoggingAdapter log = Context.GetLogger();

        private PersonState state = PersonState.Uninfected;

        public PersonActor()
        {
            log.Info($"Created person");

            Receive<StartDayMessage>(OnStartDayMessage);
            Receive<InfectedMessage>(OnInfectedMessage);
            Receive<ZombiedMessage>(OnZombiedMessage);
        }


        private void OnStartDayMessage(StartDayMessage message)
        {
            for (int i = 0; i < 5; i++)
            {
                Chat();
            }
        }

        private void Chat()
        {
            var randomPerson = Context.Parent;

            if (state == PersonState.Uninfected)
            {
                randomPerson.Tell(new ChatMessage("Hello, my friend!"));
            }
            else if (state == PersonState.Infected)
            {
                randomPerson.Tell(new InfectedMessage("Hello, my friend! I'm infected, and unfortunately I'll infect you too :("));
            }
            else if (state == PersonState.Zombied)
            {
                randomPerson.Tell(new ZombiedMessage("Hello, my friend! I'm ZOMBIE, come and join me it's not painless :)) "));
            }
        }

        private void OnInfectedMessage(InfectedMessage message)
        {
            var stats = Context.ActorSelection($"/user/{ActorNames.Stats}");
            stats.Tell(new InfectedMessage("I'm informing that I'm infected"));

            Become(Infected);
        }

        private void OnZombiedMessage(ZombiedMessage message)
        {
                var stats = Context.ActorSelection($"/user/{ActorNames.Stats}");
                stats.Tell(new ZombiedMessage("I'm informing that I'm no more human, I am a ZOMBIE"));
             Become(Zombied);


        }

        private void Zombied()
        {
            log.Info($"Zombied person");
            state = PersonState.Zombied;

            Receive<StartDayMessage>(OnStartDayMessage);
            Receive<ChatMessage>(message => Sender.Tell(new ZombiedMessage("I'm resending you a zombie blood!"), Context.Self));
        }

        private void Infected()
        {
            log.Info($"Infected person");
            state = PersonState.Infected;

            Receive<StartDayMessage>(OnStartDayMessage);
            Receive<ChatMessage>(message => Sender.Tell(new InfectedMessage("I'm resending you an infection!"), Context.Self));
        }
    }
}
