using System;

namespace pattern.behavior
{
    class State
    {
    }

    class Memento
    {
        private Memento() {}

        private State _state;
        protected State State
        {
            get { return _state; }
            set { _state = value; }
        }
        
        class Originator
        {
            public Memento CreateMemento()
            {
                return new Memento() { State = _state };
            }

            public void SetMemento(Memento memento)
            {
                _state = memento.State;
            }

            private State _state;
        }
    }
}
