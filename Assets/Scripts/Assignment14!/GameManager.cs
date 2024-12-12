using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment14
{

    // 4) Testing the Code in Unity:
    // In Unity, create another script GameManager (which inherits from
    // MonoBehavior) that will:
    // ● Create a Player and an Enemy character.
    // ● Print their Name and Health in the Unity Console.
    // ● Test the Heal() method on the player to increase their health (and
    // print them).
    // ● Test the Attack() method on the enemy to reduce the player’s health
    // (and print them).
    public class GameManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Player player = new Player("Subhi", 70);
            Enemy enemy = new Enemy("Zarifeh", 100);
            Debug.Log("Player " + player.Name + " Health " + player.Health);
            Debug.Log("Enemy " + enemy.Name + " Health " + enemy.Health);
            player.heals(20);
            enemy.Attack(player, 40);

        }

    }
}