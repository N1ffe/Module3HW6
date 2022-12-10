namespace Module3HW6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MessageBox messageBox = new MessageBox();
            Task<MessageBox.State> state = messageBox.Open();
            if (state.Result == MessageBox.State.Ok)
            {
                Console.WriteLine("Operation was accepted");
            }
            else if (state.Result == MessageBox.State.Cancel)
            {
                Console.WriteLine("Operation was cancelled");
            }
        }
    }
}