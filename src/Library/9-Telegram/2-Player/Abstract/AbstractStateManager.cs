using System;

namespace Library
{
    public abstract class AbstractPlayerStateManager : AbstractCommunicationManager
    {        
        public IPhase Phase {get; private set;}

        public AbstractPlayerStateManager(long id, IPrinter clientP)
        :base(id, clientP)
        {
            this.Phase = new WaitingForStartPhase();
        }
        public void NextState()
        {
            AbstractNextPhase next = new HeadNextPhase();
            this.Phase = next.NextPhase(this.Phase);
        }
        public void PreviousState()
        {
            AbstractPreviousPhase previous = new HeadPreviousPhase();
            this.Phase = previous.PreviousPhase(this.Phase);
        }
    }    
}