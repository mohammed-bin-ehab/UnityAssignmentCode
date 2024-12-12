using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment13
{
    public class GameManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // a. Instantiate two Player objects.
            Player player_1 = new Player();
            Player player_2 = new Player();
            Player player_3 = new Player();
            //b. Call InitializePlayer() to set playerName and health for each
            player_1.InitializePlayer("mohammed", 40);
            player_2.InitializePlayer("Ehab", 90);
            player_3.InitializePlayer("Aziz", 50);
            /*
            Use both versions of the Heal() method to demonstrate method
            overloading.
            */
            player_1.Heal(50);
            player_1.Heal(true);
            player_2.Heal(20);
            player_2.Heal(true);
            player_3.Heal(20);
            player_3.Heal(false);

            /*
            d. Call ShowPlayerCount() to display the total number of Player
            objects.
            */

            //  Debug.Log(Mutipliction_2.ShowPlayerCount());
            Player.ShowPlayerCount();

        }

    }
}