using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JW.TTRPG.ScriptableObjects
{
    [CreateAssetMenu(fileName = "I_Var", menuName = "JW/ScriptableObjects/Variables/Int")]
    public class ScriptableInt : ScriptableObject
    {
        public int Value;
    } 
}
