namespace Module3HW6
{
    public class MessageBox
    {
        public MessageBox()
        {
            Closed = state => { return state; };
        }
        public delegate State ClosedState(State state);
        public event ClosedState Closed;
        public enum State
        {
            Ok,
            Cancel
        }
        public async Task<State> Open()
        {
            Console.WriteLine("Window is open");
            await Task.Delay(3000);
            Console.WriteLine("Window is closed");
            Random rnd = new Random();
            if (rnd.Next(0, 2) == 0)
            {
                return Closed.Invoke(State.Ok);
            }
            else
            {
                return Closed.Invoke(State.Cancel);
            }
        }
    }
}
