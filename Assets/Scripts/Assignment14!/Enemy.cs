using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment14
{
    // 3) Create an Enemy Class:
    // ● Make an Enemy class that also inherits from the Character class.
    // ● Add an Attack() method that lowers (or "attacks") the Health of
    // another character by a specific amount.
    public class Enemy : Character
    {
        public Enemy(string name, int health) : base(name, health) { }

        public void Attack(Character traget, int dameg)
        {
            traget.Health = traget.Health - dameg;
            Debug.Log(Name + " attacked " + traget.Name + " for " + dameg + " dameg, " + traget.Name + "'s Health : " + traget.Health);
        }

    }
}