using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace pattern.behavior.test
{
    [TestClass]
    public class UnitTest1
    {
        public class TestableOriginator : Memento.Originator
        {
            public TestableOriginator() : base()
            {
                
            }

            public TestableOriginator(object o) : base(o)
            {
                
            }
            public State State
            {
                get { return this._state; }
            }
        }
        
        [TestMethod]
        public void Should_HaveAccessMemento__WhenOriginatorCreateMemento()
        {
            var externalState = "state1" as object;
            var originator = new TestableOriginator(externalState);
            var memento = originator.CreateMemento();

            var originator2 = new TestableOriginator();
            originator2.SetMemento(memento);
            
            Assert.AreEqual(originator.State.PropertyUpdate.First().Value, originator2.State.PropertyUpdate.First().Value);
        }
    }
}
