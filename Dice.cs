using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleDiceRoller
{
    class Dice
    {
        /// <summary>
        /// - The only purpuse of the Dice class is to emulate dice. 
        /// - Later, i realised that "Random" objects were already really good at doing that...
        /// - But i still decided to keep the Dice class and use it because it was clearer to me to instanciate dice 
        ///   then Random type objects without any flavor.
        ///   To be explicite, i rather write "oneD6.ThrowIt" which will emulate a six sided die using its property "ThrowIt" then write rdnNbr.Next(1, 7).
        ///   It speaks clearer to me. :)
        /// </summary>
        #region STATIC ELEMENTS
        #endregion
        #region STATIC VARIABLES
        #endregion

        #region STATIC CONSTRUCTORS - PROPERTIES - METHODES
        #endregion

        //===========================================
        #region INSTANCE ELEMENTS
        #endregion
        #region INSTANCE VARIABLES
        #endregion
        private int  sidesOfADie;
        private int  nbrOfDice;
        private Random dieOutcome;


        #region INSTANCE CONSTRUCTORS - PROPERTIES - METHODES
        #endregion 
        //==CONSTRUCTOR
        public Dice(int nbrOfDice, int sidesOfADie)
        {
            this.NbrOfDice = nbrOfDice;
            this.SidesOfADie = sidesOfADie;
            this.dieOutcome = new Random(DateTime.Now.Millisecond);
        }

        //==PROPERTIES
        //Set the number of dice that will be virtually thrown.
        public int NbrOfDice /*to be thrown*/
        {
            get { return this.nbrOfDice; }
            private set
            {
                //If the user enter a value that is not a number or is inferior to 1, the methode set the value to 1.
                if (value <= 0 || Regex.Match(value.ToString(),"[a-zA-Z]").Success)
                    value = 1;

                this.nbrOfDice = value;
            }
        }
        public int SidesOfADie
        {
            get { return this.sidesOfADie; }
            private set
            {
                //If the user enter a value that is not a number or is inferior to 1, the methode set the value to 6.
                if (value <= 0 || Regex.Match(value.ToString(), "[a-zA-Z]").Success)
                    value = 6;

                this.sidesOfADie = value;
            }
        }
        //The property "ThrowIT" will generate a random number set between the number of dice thrown (min) and the total sides of those dice 
        //combine plus one (max).
        public int ThrowIt
        {
            get
            {
                int retVal = 1;
                retVal = this.dieOutcome.Next(this.NbrOfDice/*min value*/, this.SidesOfADie * this.NbrOfDice + 1/*max value +1*/);
                return retVal;
            }
        }
    }
}
