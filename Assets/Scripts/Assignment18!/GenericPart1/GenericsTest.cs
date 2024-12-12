using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class GenericsTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameContainer<string> gameContainer = new GameContainer<string>();
            gameContainer.SetItem("Healing Potion");
            string storedItem = gameContainer.GetItem();
            Debug.Log("Sotred Item : " + storedItem);
            string describetion = GameUtils.DescribeItem(storedItem);
            Debug.Log(describetion);
        }

    }
}