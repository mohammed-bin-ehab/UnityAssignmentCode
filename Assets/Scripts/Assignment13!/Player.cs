using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment13
{
    public class Player
    {
        /*
        2-Define the following public fields:
        a. playerName (string)
        b. health (int)
        */

        /*
        6-Add a static field playerCount to keep track of the number of Player
        objects.
        */

        public string playerName;
        public int health;
        public static int playerCount = 0;


        /* 
        3-Implement a method InitializePlayer(string name, int initialHealth)
        to set the playerName and health.
        */

        /*
        7-Increment playerCount within the InitializePlayer() method.
        */


        public void InitializePlayer(string name, int initialHealth)
        {
            playerName = name;
            if (0 <= initialHealth && initialHealth <= 100)
            {
                health = initialHealth;
            }
            else health = 100;
            playerCount++;

        }

        /*
        4-Add a method Heal(int amount) to increase health by a specified
        amount and print the update using Debug.Log().
        */

        public void Heal(int amount)
        {
            if ((health + amount) <= 100)
            {
                health = health + amount;
                Debug.Log(playerName + " healed by  " + amount + " new health " + health);
            }
            else
            {
                Debug.Log(playerName + " The Health " + health + ", it is possible to increase the health of " + playerName + " because of (health + amount > 100), you can inrease the health of " + playerName + " by a specific amount which is to be (health + amount <= 100).");
                // Debug.Log(" No incremmnt of health Player becuase (Amont + Health > 100  but make the health = ) " + playerName + " the health " + health);
            }
        }
        /*
        5-Overload the Heal() method to accept a bool fullRestore parameter
        to fully restore health when set to true.
        */

        public void Heal(bool fullRestore)
        {
            if (fullRestore)
            {
                health = 100;
                Debug.Log(playerName + " The Health = " + health);
            }
        }

        /*
        8. Create a static method ShowPlayerCount() to print playerCount
        using Debug.Log().
        */

        public static void ShowPlayerCount()
        {
            Debug.Log("Player Count = " + playerCount);
        }

    }

}