using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
    public class CharacterTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

            Character[] characters = new Character[2];
            characters[0] = new Soldier();
            characters[1] = new Officer("Smith", 80, new Position(5f, 10f, 15f));

            foreach (Character character in characters)
            {
                character.Displayifo();
            }
            characters[0].Attack(30, characters[1], "Shooting");



        }

    }
}