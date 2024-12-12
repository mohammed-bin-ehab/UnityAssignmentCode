using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16
{
    public class Soldier : Character
    {

        public Soldier(string name, int health, Position position) : base(name, health, position) { }
        public Soldier() : base() { }

        public override void Displayifo()
        {
            Debug.Log("Soldier ");
            base.Displayifo();
        }
    }
}