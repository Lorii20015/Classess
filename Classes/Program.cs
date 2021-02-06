using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball SoccerBall = new Ball(3, 2, "black 'n white colored ball", " ball that's used to play soccer", "I have nice symetry and a lot of pentagons!");
            Ball FootballBall = new Ball(3, 2, "orange 'n white colored ball", " ball that's used to play football", "I have kinda funny shape!");
            Ball PingpongBall = new Ball(1, 3, "usually white colored ball", " ball that's used for ping-pong", "I am super hard to catch!");
            List<Ball> Balls = new List<Ball>();
            Balls.Add(SoccerBall);
            Balls.Add(FootballBall);
            Balls.Add(PingpongBall);
            for (int a = 0; a < Balls.Count; a++)
            {
                //Ball CurrentBall = Balls[a];
                int SizeOfBall = Balls[a].BallSize;
                int SpeedOfBall = Balls[a].BallSpeed;
                string ColorOfBall = Balls[a].BallColor;
                string FactOfBall = Balls[a].BallFact;
                string bsize = "";
                string bspeed = "";
                if (SizeOfBall == 1)
                {
                    bsize = "not very";
                }
                if (SizeOfBall == 2)
                {
                    bsize = "kinda";
                }
                if (SizeOfBall == 3)
                {
                    bsize = "very";
                }
                if (SpeedOfBall == 1)
                {
                    bspeed = "not very";
                }
                if (SpeedOfBall == 2)
                {
                    bspeed = "kinda";
                }
                if (SpeedOfBall == 3)
                {
                    bspeed = "very";
                }
                Console.WriteLine("Hi, I'm a " + ColorOfBall + ". I'm " + bspeed + " fast, and " + bsize + " big! An interesting fact about me is that " + FactOfBall);
            }
        }
    }       
}