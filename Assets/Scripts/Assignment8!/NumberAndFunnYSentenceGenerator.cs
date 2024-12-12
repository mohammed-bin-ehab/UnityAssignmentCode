using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class NumberAndFunnYSentenceGenerator : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int count = 0;
            while (count < 20)
            {
                int numRandom = Random.Range(1, 21);
                if (numRandom == 5)
                {
                    continue;
                }
                if (numRandom == 15)
                {
                    break;
                }
                Debug.Log(numRandom);
                count++;
            }

            Debug.Log("###***###***###***###***###***###***###***");

            string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
            string funnySentence = "";
            int countWords = 0;
            while (countWords < 7)
            {
                int index = Random.Range(0, words.Length);
                funnySentence += words[index] + " ";
                countWords++;
            }
            Debug.Log("funny Sentence : " + funnySentence);
        }

    }
