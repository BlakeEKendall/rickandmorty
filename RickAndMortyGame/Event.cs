using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RickAndMortyGame.Event;
using static RickAndMortyGame.ProgramUI;

namespace RickAndMortyGame
{
    public class Event
    {
        public enum EventType { newExit, getItem }
        public string useTrigger;
        // public string lookTrigger;

        public Result EventResult;
    }

    public class Result
    {
        public EventType Type;
        public string ResultDestination;
        public Item ResultItem;

        public Result(string resultDestination)
        {
            Type = EventType.newExit;
            ResultDestination = resultDestination;
        }
        public Result(Item resultItem)
        {
            Type = EventType.newExit;
            ResultItem = resultItem;
        }
    }
}
