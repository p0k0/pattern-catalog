using System;

namespace pattern.behavior
{
    partial class Memento
    {
        private Memento() {}

        private State _state;
        protected State State
        {
            get { return _state; }
            set { _state = value; }
        }
    }
}
