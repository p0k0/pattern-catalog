namespace pattern.behavior
{
    partial class Memento
    {
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