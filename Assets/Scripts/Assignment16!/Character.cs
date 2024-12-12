using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
    public class Character
    // Base Class
    {
        public string name;
        private int health, a;
        protected Position position;


        public int Health
        {
            get { return health; }
            set
            {
                if (value > 100) health = 100;
                else if (value < 0) health = 0;
                else health = value;
            }
        }

        public Character(string name, int health, Position position)
        {
            this.name = name;
            this.Health = health;
            this.position = position;
        }

        public Character() : this("No name", 100, new Position(0, 0, 0)) { }


        public virtual void Displayifo()
        {
            Debug.Log(" Player Name : " + this.name);
            Debug.Log(" Health = " + this.Health);
            position.PrintPosition();
        }

        public void Attack(int damage, Character traget)
        {
            Debug.Log("The Health befor damage = " + traget.Health + " The Damge Of " + damage);
            traget.Health = traget.Health - damage;
            Debug.Log("The Health After damage = " + traget.Health);

        }

        public void Attack(int damage, Character traget, string attackType)
        {

            Debug.Log("The Player`s health is equal = " + traget.Health + " to the damage Of " + damage + " he sustained and the attack was " + attackType);
            traget.Health = traget.Health - damage;
            Debug.Log("The Health After damage = " + traget.Health);

        }
    }
}