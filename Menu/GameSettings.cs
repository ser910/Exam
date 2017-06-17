using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class GameSettings
    {
        public int speed { get; set; }
        public double angle; 
        
        public int degreeAngle 
        { 
            get
            {
                return (int)Math.Round(180 * angle / Math.PI);
            }
            set
            {
                angle = value * Math.PI / 180;
            }
        }
        public int X 
        {
            get 
            {
                double x = speed * Math.Cos(angle)+restX;
                double getX = Math.Round(x);
                restX = x-getX; 
                return (int)getX;
            }
            private set 
            {
                X = value;
            }
                
        }
        public int Y
        {
            get 
            {
                double y = speed * Math.Sin(angle)+restY;
                
                double getY = Math.Round(y);
                restY = y-getY; 
                return (int)getY;
            }
            private set 
            {
                Y = value;
            }    
        }
        double restX;
        double restY;
        public Size Gamefield;
        public GameSettings(int speed, double angle, Size Gamefield)
        {
            this.speed = speed;
            this.angle = angle;
            this.Gamefield = Gamefield;
        }

    }
}
