using System.Collections.Generic;

namespace pattern.behavior
{
    
    partial class Memento
    {
        public class Originator
        {
            public Originator()
            {
                Initialize();
            }
            
            public Originator(object o)
            {
                Initialize();
                _state.PropertyUpdate[nameof(o)] = o;
            }

            private void Initialize()
            {
                _state = new State() { PropertyUpdate = new Dictionary<string, object>() };
            }
            
            public virtual Memento CreateMemento()
            {
                return new Memento(_state);
            }

            public virtual void SetMemento(Memento memento)
            {
                _state = memento._state;
            }

            protected State _state;
        }
    }
}