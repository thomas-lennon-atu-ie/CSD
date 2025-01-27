using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aliens.Models
{
    internal class Raygun
    {
        // Properties
        
        //The maximum charge the Raygun can hold
        public int MaxCharge { get; set; }

        //The current level of charge the Raygun has
        public int CurrentCharge { get; set; }

        public Raygun(int mChrg, int cChrg)
        {
            MaxCharge = mChrg;
            CurrentCharge = Math.Clamp(cChrg, 0, MaxCharge);
        }

        // Methods
        

        public void FireAt(Alien a)
        {
            {
                if (IsCharged()) // Check if the gun has charge
                {
                    CurrentCharge--; // reduce by 1

                    if (a.Dodging)
                    {
                        a.Miss(); // dodged
                    }
                    else
                    {
                        a.Hit(); //hit
                    }
                }
            }
            /*The gun should only fire if it is charged. Firing the gun will reduce the charge by 1. If the alien isDodging
            * alien.miss() should be called, otherwise alien.hit */

        }

        public void Recharge()
        {
            if (!IsFullyCharged())
            {
                CurrentCharge++;  //increase by1
            }
        }

        public bool IsCharged()
        {
            return CurrentCharge > 0;

        }

        public bool IsFullyCharged()
        {
            return CurrentCharge == MaxCharge;
        }


    }
}
