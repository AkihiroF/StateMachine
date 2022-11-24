namespace Source.States
{
    public abstract class AState
    {

        protected AState()
        {
        }
        public abstract void Enter();
        public abstract void Exit();
        public abstract void Update();
    }
}
