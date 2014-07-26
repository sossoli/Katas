namespace MarsRover
{
    public class FaceWest : FaceBase, IFacing
    {
        public FaceWest()
        {
            _direction = Face.West;
        }

        public IFacing GetFacingForward(IPosition position)
        {
            position.DecrementX();
            return new FaceWest();
        }

        public IFacing GetFacingLeft(IPosition position)
        {
            return new FaceSouth();
        }

        public IFacing GetFacingRight(IPosition position)
        {
            return new FaceNorth();
        }

        public IFacing GetFacingBack(IPosition position)
        {
            return new FaceEast();
        }
    }
}