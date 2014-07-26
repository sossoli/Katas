namespace MarsRover
{
    public class FaceEast : FaceBase, IFacing
    {
        public FaceEast()
        {
            _direction = Face.East;
        }

        public IFacing GetFacingForward(IPosition position)
        {
            position.IncrementX();
            return new FaceEast();
        }

        public IFacing GetFacingLeft(IPosition position)
        {
            return new FaceNorth();
        }

        public IFacing GetFacingRight(IPosition position)
        {
            return new FaceSouth();
        }

        public IFacing GetFacingBack(IPosition position)
        {
            return new FaceWest();
        }
    }
}