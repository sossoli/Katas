namespace MarsRover
{
    public class FaceSouth : FaceBase, IFacing
    {
        
        public FaceSouth()
        {
            _direction = Face.South;
        }

        public IFacing GetFacingForward(IPosition position)
        {
            position.DecrementY();
            return new FaceSouth();
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
            return new FaceNorth();
        }
    }
}