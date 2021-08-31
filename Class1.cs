using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeter_Opgave
{
    class Planeter // Vi opretter vores Planeter class
    {
        // Attributer til vores class
        private float mass;
        private int diameter;
        private int density;
        private float gravity;
        private float rotationPeriod;
        private float dayLength;
        private float sunDistance;
        private float orbitPeriod;
        private float orbitVelocity;
        private int temperature;
        private int moons;
        private string ringSystem;
        private string name;

        // Tom constructor indsættes her
        public Planeter()
        {

        }

        // Her get/setter vi en værdi til de
        // forskellige parametre som planeten består af
        public float Mass
        {
            get
            {
                return mass;
            }
            set
            {
                this.mass = value;
            }
        }

        public int Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                this.diameter = value;
            }
        }

        public int Density
        {
            get
            {
                return density;
            }
            set
            {
                this.density = value;
            }
        }

        public float Gravity
        {
            get
            {
                return gravity;
            }
            set
            {
                this.gravity = value;
            }
        }

        public float RotationPeriod
        {
            get
            {
                return rotationPeriod;
            }
            set
            {
                this.rotationPeriod = value;
            }
        }

        public float DayLength
        {
            get
            {
                return dayLength;
            }
            set
            {
                this.dayLength = value;
            }
        }

        public float SunDistance
        {
            get
            {
                return sunDistance;
            }
            set
            {
                this.sunDistance = value;
            }
        }

        public float OrbitPeriod
        {
            get
            {
                return orbitPeriod;
            }
            set
            {
                this.orbitPeriod = value;
            }
        }

        public float OrbitVelocity
        {
            get
            {
                return orbitVelocity;
            }
            set
            {
                this.orbitVelocity = value;
            }
        }

        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                this.temperature = value;
            }
        }

        public int Moons
        {
            get
            {
                return moons;
            }
            set
            {
                this.moons = value;
            }
        }

        public string RingSystem
        {
            get
            {
                return ringSystem;
            }
            set
            {
                this.ringSystem = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

    }
}
