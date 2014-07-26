namespace MarsRover
{
    public class Rover
    {
        private readonly IPosition _position;
        private IFacing _facing;

        public IPosition Position { get { return _position; }}
        public IFacing Facing { get {return _facing; }}

        public Rover()
        {
            _position = new Position();
            _facing = new FaceNorth();
        }

        public void Forward()
        {
            _facing = _facing.GetFacingForward(_position);
        }

        public void Left()
        {
            _facing = _facing.GetFacingLeft(_position);
        }

        public void Right()
        {
            _facing = _facing.GetFacingRight(_position);
        }

        public void Back()
        {
            _facing = _facing.GetFacingBack(_position);
        }
    }
}