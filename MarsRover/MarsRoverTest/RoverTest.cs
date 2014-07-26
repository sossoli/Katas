using MarsRover;
using Xunit;

namespace MarsRoverTest
{
    public class RoverTest
    {
        private Rover _rover;

        public RoverTest()
        {
            _rover = new Rover();
        }

        [Fact]
        public void Posizione_iniziale_deve_essere_0_0()
        {
            Assert.Equal(0, _rover.Position.X);
            Assert.Equal(0, _rover.Position.Y);
        }

        [Fact]
        public void Facing_iniziale_deve_essere_North()
        {
            Assert.Equal(Face.North, _rover.Facing.Direction);
        }

        [Fact]
        public void FacingNorth_comando_Forward_deve_restare_direction_North()
        {
            _rover.Forward();

            Assert.Equal(Face.North, _rover.Facing.Direction);
        }

        [Fact]
        public void FacingNorth_comando_left_deve_diventare_direction_West()
        {
            _rover.Left();

            Assert.Equal(Face.West, _rover.Facing.Direction);
        }

        [Fact]
        public void FacingNorth_comando_right_deve_diventare_direction_East()
        {
            _rover.Right();

            Assert.Equal(Face.East, _rover.Facing.Direction);
        }

        [Fact]
        public void FacingNorth_comando_Back_deve_diventare_direction_South()
        {
            _rover.Back();

            Assert.Equal(Face.South, _rover.Facing.Direction);
        }


        [Fact]
        public void FacingEst_comando_Forward_deve_restare_direction_Est()
        {
            _rover.Right();

            _rover.Forward();

            Assert.Equal(Face.East, _rover.Facing.Direction);
        }

        [Fact]
        public void FacingEst_comando_right_deve_diventare_direction_South()
        {
            _rover.Right();

            _rover.Right();

            Assert.Equal(Face.South, _rover.Facing.Direction);
        }

        [Fact]
        public void FacingEst_comando_left_deve_diventare_direction_North()
        {
            _rover.Right();

            _rover.Left();

            Assert.Equal(Face.North, _rover.Facing.Direction);
        }


        [Fact]
        public void FacingEst_comando_Back_deve_diventare_direction_West()
        {
            _rover.Right();

            _rover.Back();

            Assert.Equal(Face.West, _rover.Facing.Direction);
        }


        [Fact]
        public void FacingSouth_comando_Forward_deve_diventare_direction_South()
        {
            _rover.Back();

            _rover.Forward();

            Assert.Equal(Face.South, _rover.Facing.Direction);
        }

        [Fact]
        public void FacingSouth_comando_Left_deve_diventare_direction_West()
        {
            _rover.Back();

            _rover.Left();

            Assert.Equal(Face.West, _rover.Facing.Direction);
        }

        [Fact]
        public void FacingSouth_comando_Rigt_deve_diventare_direction_East()
        {
            _rover.Back();

            _rover.Right();

            Assert.Equal(Face.East, _rover.Facing.Direction);
        }

        [Fact]
        public void FacingSouth_comando_Back_deve_diventare_direction_North()
        {
            _rover.Back();

            _rover.Back();

            Assert.Equal(Face.North, _rover.Facing.Direction);
        }


        [Fact]
        public void FacingWest_comando_Forward_deve_diventare_direction_West()
        {
            _rover.Left();

            _rover.Forward();

            Assert.Equal(Face.West, _rover.Facing.Direction);
        }

        [Fact]
        public void FacingWest_comando_Left_deve_diventare_direction_North()
        {
            _rover.Left();

            _rover.Left();

            Assert.Equal(Face.South, _rover.Facing.Direction);
        }

        [Fact]
        public void FacingWest_comando_Right_deve_diventare_direction_South()
        {
            _rover.Left();

            _rover.Right();

            Assert.Equal(Face.North, _rover.Facing.Direction);
        }

        [Fact]
        public void FacingWest_comando_Back_deve_diventare_direction_East()
        {
            _rover.Left();

            _rover.Back();

            Assert.Equal(Face.East, _rover.Facing.Direction);
        }


        [Fact]
        public void FacingNorth_comando_Forward_deve_diventare_Posizione_0_1()
        {
            _rover.Forward();

            Assert.Equal(0, _rover.Position.X);
            Assert.Equal(1, _rover.Position.Y);
        }

        [Fact]
        public void FacingNorth_comando_Left_deve_diventare_Posizione_1_negativo_0()
        {
            _rover.Left();

            Assert.Equal(0, _rover.Position.X);
            Assert.Equal(0, _rover.Position.Y);
        }

        [Fact]
        public void FacingNorth_comando_Right_deve_diventare_Posizione_1_0()
        {
            _rover.Right();

            Assert.Equal(0, _rover.Position.X);
            Assert.Equal(0, _rover.Position.Y);
        }

        [Fact]
        public void FacingNorth_comando_Back_deve_diventare_Posizione_0_1_negativo()
        {
            _rover.Back();

            Assert.Equal(0, _rover.Position.X);
            Assert.Equal(0, _rover.Position.Y);
        }

        [Fact]
        public void FacingEast_comando_Forward_deve_diventare_Posizione_2_0()
        {
            _rover.Right();

            _rover.Forward();

            Assert.Equal(1, _rover.Position.X);
            Assert.Equal(0, _rover.Position.Y);
        }

        [Fact]
        public void FacingEast_comando_left_deve_diventare_Posizione_0_0()
        {
            _rover.Right();

            _rover.Left();

            Assert.Equal(0, _rover.Position.X);
            Assert.Equal(0, _rover.Position.Y);
        }

        [Fact]
        public void FacingEast_comando_right_deve_diventare_Posizione_0_0()
        {
            _rover.Right();

            _rover.Right();

            Assert.Equal(0, _rover.Position.X);
            Assert.Equal(0, _rover.Position.Y);
        }

        [Fact]
        public void FacingEast_comando_Back_deve_diventare_Posizione_0_0()
        {
            _rover.Right();

            _rover.Back();

            Assert.Equal(0, _rover.Position.X);
            Assert.Equal(0, _rover.Position.Y);
        }


        [Fact]
        public void FacingWest_comando_Forward_deve_diventare_Posizione_2_negativo_0()
        {
            _rover.Left();

            _rover.Forward();

            Assert.Equal(-1, _rover.Position.X);
            Assert.Equal(0, _rover.Position.Y);
        }

        [Fact]
        public void FacingWest_comando_Left_deve_diventare_Posizione_1_negativo_1_negativo()
        {
            _rover.Left();

            _rover.Left();

            Assert.Equal(0, _rover.Position.X);
            Assert.Equal(0, _rover.Position.Y);
        }

        [Fact]
        public void FacingWest_comando_Right_deve_diventare_Posizione_0_0()
        {
            _rover.Left();

            _rover.Right();

            Assert.Equal(0, _rover.Position.X);
            Assert.Equal(0, _rover.Position.Y);
        }

        [Fact]
        public void FacingWest_comando_Back_deve_diventare_Posizione_0_0()
        {
            _rover.Left();

            _rover.Back();

            Assert.Equal(0, _rover.Position.X);
            Assert.Equal(0, _rover.Position.Y);
        }

        [Fact]
        public void FacingSoutn_comando_Forward_deve_diventare_Posizione_01_negativo()
        {
            _rover.Back();

            _rover.Forward();

            Assert.Equal(0, _rover.Position.X);
            Assert.Equal(-1, _rover.Position.Y);
        }

        [Fact]
        public void FacingSoutn_comando_Right_deve_diventare_Posizione_0_0()
        {
            _rover.Back();

            _rover.Right();

            Assert.Equal(0, _rover.Position.X);
            Assert.Equal(0, _rover.Position.Y);
        }

        [Fact]
        public void FacingSoutn_comando_left_deve_diventare_Posizione_()
        {
            _rover.Back();

            _rover.Left();

            Assert.Equal(0, _rover.Position.X);
            Assert.Equal(0, _rover.Position.Y);
        }

        [Fact]
        public void FacingSoutn_comando_Back_deve_diventare_Posizione_0_0()
        {
            _rover.Back();

            _rover.Back();

            Assert.Equal(0, _rover.Position.X);
            Assert.Equal(0, _rover.Position.Y);
        }

        [Fact]
        public void FFRFF_deve_arrivare_alla_posizione_2_2()
        {
            _rover.Forward();
            _rover.Forward();
            _rover.Right();
            _rover.Forward();
            _rover.Forward();

            Assert.Equal(2, _rover.Position.X);
            Assert.Equal(2, _rover.Position.Y);

        }
    }
}
