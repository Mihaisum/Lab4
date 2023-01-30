﻿using OpenTK;
using System;
using System.Drawing;

namespace TEMA_3
{
    /// <summary>
    /// This class generates various random values for different kind of parameters (<see cref="Random()"/>).
    /// </summary>
    class Randomizer
    {
        private Random r;
        private int LOW_INT_VAL = -25;
        private int HIGH_INT_VAL = 25;
        private int LOW_COORD_VAL = -50;
        private int HIGH_COORD_VAL = 50;

        /// <summary>
        /// Standard constructor. Initialised with the system clock for seed.
        /// </summary>

        public Randomizer()
        {
            r = new Random();
        }

        /// <summary>
        /// This method returns an random color when requested.
        /// </summary>
        /// <returns>The color, randomly generated!</returns>
        public Color RandomColor()
        {
            int genR = r.Next(0, 255);
            int genG = r.Next(0, 255);
            int genB = r.Next(0, 255);

            Color col = Color.FromArgb(genR, genG, genB);

            return col;
        }

        /// <summary>
        /// This method returns a random 3D coordinate. Values are ranged (0-centered).
        /// </summary>
        /// <returns>the 3D point's coordinates, randomly generated!</returns>

        public Vector3 Random3DPoint()
        {
            int genA = r.Next(LOW_COORD_VAL, HIGH_COORD_VAL);
            int genB = r.Next(LOW_COORD_VAL, HIGH_COORD_VAL);
            int genC = r.Next(LOW_COORD_VAL, HIGH_COORD_VAL);

            Vector3 vect = new Vector3(genA, genB, genC);

            return vect;
        }

        /// <summary>
        /// This method returns a random int when required. The value is ranged between predifined values (symmetrical over zero).
        /// </summary>
        /// <returns>random integer;</returns>

        public int RandomInt()
        {
            int i = r.Next(LOW_INT_VAL, HIGH_INT_VAL);

            return i;
        }

        /// <summary>
        /// This method returns a random int when required. The value is ranged between given values.
        /// </summary>
        /// <param name="minVal">minimum value for the randomized range;</param>
        /// <param name="maxVal">maximum value for the randomized range;</param>
        /// <returns>random integer;</returns>
        public int RandomInt(int minVal, int maxVal)
        {
            int i = r.Next(minVal, maxVal);

            return i;
        }

        /// <summary>
        /// This method returns a random int when required. The value is ranged between 0 and a given value.
        /// </summary>
        /// </summary>
        /// <param name="maxval">upper value for integer genration;</param>
        /// <returns>random integer;</returns>

        public int RandomInt(int maxval)
        {
            int i = r.Next(maxval);

            return i;
        }

    }
}
