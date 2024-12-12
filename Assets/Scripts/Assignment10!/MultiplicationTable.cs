using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment10
{
    public class muplynum : MonoBehaviour
    {
        void Start()
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                int result = Multiply(5, i);
                Debug.Log(5 + " * " + i + " = " + result);
            }
        }

        int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}