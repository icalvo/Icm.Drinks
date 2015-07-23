using System;
using System.Collections.Generic;

namespace Icm.Drinks.Domain
{
    public class SynchronousEventBus : IEventBus
    {
        private readonly Dictionary<Type, List<Action<object>>> _handlers = new Dictionary<Type, List<Action<object>>>();

        public void Register<T>(Action<T> handlerAction)
        {
            Type type = typeof (T);
            if (!_handlers.ContainsKey(type))
            {
                _handlers.Add(type, new List<Action<object>>());
            }

            _handlers[type].Add(x => handlerAction((T)x));
        }

        public void Send(object eventToBeSent)
        {
            Type type = eventToBeSent.GetType();
            if (!_handlers.ContainsKey(type))
            {
                return;
            }

            foreach (Action<object> action in _handlers[type])
            {
                action(eventToBeSent);
            }
        }
    }
}