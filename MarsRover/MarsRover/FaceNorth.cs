namespace MarsRover
{
    public class FaceNorth : FaceBase, IFacing
    {
        public FaceNorth()
        {
            _direction = Face.North;
        }

        public IFacing GetFacingForward(IPosition position)
        {
            position.IncrementY();
            return new FaceNorth();
        }

        public IFacing GetFacingLeft(IPosition position)
        {
            return new FaceWest();
        }

        public IFacing GetFacingRight(IPosition position)
        {
            return new FaceEast();
        }

        public IFacing GetFacingBack(IPosition position)
        {
            return new FaceSouth();
        }
    }
}