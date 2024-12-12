using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment14
{
    // 2) Create a Player Class:
    // ● Make a Player class that inherits from the Character class.
    // ● Add a Heal() method that increases (or "heals") the player’s Health
    // by a certain amount.
    public class Player : Character
    {
        public Player(string name, int health) : base(name, health) { }
        //    Debug.Log(Player.Heal(20));

        // public void Heal(int amount)
        // {
        //     if((Health+amount) <= 100 ){
        //   Health = Health + amount;
        //   Debug.Log(Name + " healed by  " + amount +" new health " + Health);
        //  }
        //  else
        //  {
        //     Debug.Log(Name +" The Health "+ Health +", it is possible to increase the health of "+ Name +" because of (health + amount > 100), you can inrease the health of "+ Name +" by a specific amount which is to be (health + amount <= 100).");
        //      }
        // }
        public void heals(int amount)
        {
            Health = Health + amount;
            Debug.Log(Name + " by healed " + amount + " health = " + Health);
        }

    }
}