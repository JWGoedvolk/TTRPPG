using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JW.TTRPG.ScriptableObjects
{
    [CreateAssetMenu(fileName = "S_Var", menuName = "JW/ScriptableObjects/Variables/String")]
    public class ScriptableString : ScriptableObject
    {
        public string Value;
    } 
}
