Memento
- save `Originator` inner state part (or state difference)
- restrict all access except `Originator` instance

Originator
- create `Memento` and use it for inner state recovering

State
- contain information about `Originator` 