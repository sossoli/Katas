namespace MarsRover
{
    public interface IPosition
    {
        int X { get; }
        int Y { get; }
        void IncrementX();
        void DecrementY();
        void IncrementY();
        void DecrementX();
    }

    public class Position : IPosition
    {
        
        public int X { get; private set; }
        public int Y { get; private set; }

        public void IncrementX()
        {
            X +=1;
        }

        public void DecrementY()
        {
            Y -= 1;
        }

        public void IncrementY()
        {
            Y += 1;
        }

        public void DecrementX()
        {
            X -= 1;
        }
    }
}