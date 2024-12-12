using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment5
{


    public class ExampleScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int num = 5;
            string name = "mohammed";
            Debug.Log(num + 10);
            Debug.Log(name);
            Debug.LogWarning("Tahtheer");
            Debug.LogError("Musibah");
        }
    }
}