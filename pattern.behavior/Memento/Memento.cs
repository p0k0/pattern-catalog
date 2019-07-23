using System;

namespace pattern.behavior
{
    public partial class Memento
    {
        private Memento(State state) { _state = state; }

        private State _state;
    }
}
