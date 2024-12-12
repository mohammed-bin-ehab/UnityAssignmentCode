using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment14
{
    // 1) Create a Base Class (Character):
    // ● Create a class called Character that will be a base (or parent) class.
    // ● This class will have two properties:
    // ○ string Name: The character's name (for example, "Subhi" or
    // "Zarifeh").
    // ○ int Health: The character's health (max is 100).
    // ● Use getters and setters for both properties to control and protect the
    // information stored in them.
    // ● Make a constructor to set up the character's Name and Health when
    // the character is created.
    public class Character
    {
        private string name;
        private int health;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Health
        {
            get { return this.health; }
            set
            {
                if (value > 100) this.health = 100;
                else if (value < 0) this.health = 0;
                else this.health = value;

            }
        }
        public Character(string name, int health)
        {
            this.name = name;
            this.health = health;
        }
    }

}