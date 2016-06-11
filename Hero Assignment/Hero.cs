using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Christopher Ritchil 
 * Student # : 300702644
 * Date Modified: June 10, 2016
 * Date Created: Jun 01, 2016
 * Description: This program demonstrate COMP123 Assignment #1 COMP123 S2016 Assignment #1 requirements
 * Version: 0.1.0
 */

namespace Hero_Assignment
{
    class Hero
    {
        // Private instance variables/fields ++++++++++++++++++++++++++++

        private int _strength;
        private int _speed;
        private int _health;
        private string _name;

        // Public properties ++++++++++++++++++++++++++++++++++++++++++++


        /**
         * 
         * <summary>
         * This is a public property for _strength field
         * </summary>
         * 
         * @property {int} Strength
         */


        public int Strength
        {
            get
            {
                return this._strength;
            }
            set
            {
                this._strength = value;
            }
        }


        /**
         * 
         * <summary>
         * This is a property for _speed field
         * </summary>
         * 
         * @property {int} Speed
         */


        public int Speed
        {
            get
            {
                return this._speed;
            }
            set
            {
                this._speed = value;
            }
        }


        /**
         * 
         * <summary>
         * This is a property for _health field
         * </summary>
         * @property {int} Health
         * 
         */


        public int Health
        {
            get
            {
                return this._health;
            }
            set
            {
                this._health = value;
            }
        }


        /**
         * 
         * <summary>
         * This is a property for  _name field
         * </summary>
         * @property {string} Name
         * 
         */



        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }


        /**
         * <summary>
         * This is a constructor that takes name as parameters.   
         * </summary>
         * 
         * @constructor Hero
         * @param {string} _name
         * 
         */


        public Hero(string _name)
        {
            this.Name = _name;
            this._generateAbilities();
        }


        // Private methods +++++++++++++++++++++++++++++++++


        /**
         * <summary>
         * This method generates random integers for _strength, _ speed & _health
         * </summary>
         * 
         * @method _generateAbilities
         * @returns {void}
         */


        private void _generateAbilities()
        {

            Random number = new Random();
            _strength = number.Next(1, 101);
            _speed = number.Next(1, 101);
            _health = number.Next(1, 101);

        }


        /**
         * <summary>
         * This method generates 20 percent hit attempt possibility
         * </summary>
         * 
         * @method _hitAttempt
         * @returns {bool}
         */


        private bool _hitAttempt()
        {

            Random num = new Random();
            if (num.Next(1, 6) == 1)
            {
                return true;
            }
            else { return false; }
        }

        /**
         * <summary>
         * This method calculates the amount of damage based on Hero _strength by a randomly generated number
         * </summary>
         * 
         * @method _hitDamage
         * @returns {int} damage
         */

        private int _hitDamage()
        {
            Random num = new Random();
            int damage = _strength * num.Next(1, 7);
            return damage;
        }

        // Public methods ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method outputs value from _hitDamage based on _hitAttempt 
         * </summary>
         * 
         * @method Fight
         * @returns {void}
         */

        public void Fight()
        {
            if (_hitAttempt())
            {
                Console.WriteLine("    Hi {0}, Weldone! {1}  Damages",_name, _hitDamage());
                Console.WriteLine("---------------------------------------------");
            }

            else
            {
                Console.WriteLine("    Hi {0}, You Missed, Try Again!",_name);
                Console.WriteLine("---------------------------------------------");
            }
            
        }

        /**
         * <summary>
         * This method outputs Strength, Speed and Health value for hero
         * </summary>
         * 
         * @method Show
         * @returns {void}
         */
        public void Show()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("      Strength: " + _strength);
            Console.WriteLine("         Speed: " + _speed);
            Console.WriteLine("        Health: " + _health);
            Console.WriteLine("_____________________________________________");
        }
    }
}
