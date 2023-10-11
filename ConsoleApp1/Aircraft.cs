using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Aircraft
    {
        private float speed;
        private float maxSpeed;
        private float height;
        private float maxHeight;
        private float weight;
        private float maxWeight;

        public float Speed { get { return speed; } }
        public float Height{ get { return height; } }
        public float Weight{ get { return weight; } }

        public Aircraft()
        {
            
        }

        public Aircraft(float maxSpeed, float maxHeight, float maxWeight)
        {
            this.maxHeight = maxHeight;
            this.maxSpeed = maxSpeed;
            this.maxWeight = maxWeight;
        }

        private bool Check(float characteristic, float value)
        {
            if (value > characteristic)
            {
                return false;
            }
            return true;
        }

        public void IncreaseSpeed(float value) 
        {
            if (Check(maxSpeed, speed + value))
            {
                this.speed += value;
            }
            else
            {
                Console.WriteLine("We can't go faster");
            }
        }
        public void DecreaseSpeed(float value)
        {
            if (speed - value > 0)
            {
                this.speed += value;
            }
            else
            {
                Console.WriteLine("We can't go slower");
            }
        }
        public void IncreaseHeight(float value)
        {
            if (Check(maxHeight, height + value))
            {
                this.height+= value;
            }
            else
            {
                Console.WriteLine("We can't go higher");
            }
        }
        public void DecreaseHeight(float value)
        {
            if (height - value > 0)
            {
                this.height += value;
            }
            else
            {
                Console.WriteLine("We can't go lower");
            }
        }
    }
}
