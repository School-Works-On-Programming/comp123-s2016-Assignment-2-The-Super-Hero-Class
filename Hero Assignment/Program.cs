using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Christopher Ritchil 
 * Student # : 300702644
 * Date Modified: June 1, 2016
 * Description: This program demonstrate COMP123 S2016 SuperHero Assignment #2 requirements
 * Version: 0.2.0
 */

namespace Hero_Assignment
{
    /**
     * 
     * This class is driver class for Program
     * 
     * @class Program
     */
    class Program
    {   /**
         * 
         * this main method for driver class Program
         * 
         * @method Main
         * @param {string[]} args
         */
        static void Main(string[] args)
        {
            // create instance of the SuperHero Class
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            SuperHero HiroNakamura = new SuperHero("Hiro Nakamura");
            HiroNakamura.Fight();
            HiroNakamura.Show();
            HiroNakamura.ShowPower();
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");
        }

    }
}
