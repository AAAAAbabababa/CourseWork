namespace Kursach.GameObjects
{
    class Dinosaur : GameObject
    {
        public bool IsAlive { get; private set; } = true;
        public void Kill() => IsAlive = false;


        readonly int maxLevel;

        bool isJumping = false;
        bool isFalling = false;

        public override void Update(GameWorld world)
        {
            if ( !(isJumping || isFalling) && Controls.IsSpacePressed )
            {
                isJumping = true;
            }


            if ( isJumping )
            {
                if ( Y <= maxLevel )
                {
                    Y++;
                }
                else
                {
                    isJumping = false;
                    isFalling = true;
                }
            }

            if ( isFalling )
            {
                if ( Y == 2 )
                {
                    isFalling = false;
                }
                else
                {
                    Y--;
                }
            }
        }

        public Dinosaur(char[,] pixels, int x, int y, uint jumpLevel)
        {
            X = x;
            Y = y;

            maxLevel = y + ( int ) jumpLevel;
            this.pixels = pixels;
        }
    }
}
