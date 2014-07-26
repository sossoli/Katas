namespace MarsRover
{
    public interface IFacing
    {
        Face Direction { get; }
        IFacing GetFacingForward(IPosition position);
        IFacing GetFacingLeft(IPosition position);
        IFacing GetFacingRight(IPosition position);
        IFacing GetFacingBack(IPosition position);
    }

    public abstract class FaceBase
    {
        protected Face _direction;

        public Face Direction { get { return _direction; } }
    }
}