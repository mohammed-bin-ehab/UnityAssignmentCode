using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
    public struct Position
    {
        public float X, Y, Z;

        public Position(float X, float Y, float Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public void PrintPosition()
        {
            Debug.Log("Position(X =  " + this.X + ",Y =  " + this.Y + ",Z = " + this.Z + ")");
        }
    }
}