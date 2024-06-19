using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JW.TTRPG.ScriptableObjects;

namespace JW.TTRPG.Utility
{
    [CreateAssetMenu(fileName = "Roller", menuName = "JW/ScriptableObjects/Utilities/DiceRoller")]
    public class DiceRoller : ScriptableObject
    {
        #region Variables
        [SerializeField] private ScriptableString equation;
        [SerializeField] private ScriptableInt result;
        #endregion

        #region Public Functions
        public void Roll(ScriptableString formula)
        {
            Debug.Log($"Rolling {formula.Value}");
            var toRoll = formula.Value.Split('d');

            int numDice = int.Parse(toRoll[0]);
            int diceSize = int.Parse(toRoll[1]);

            int total = 0;
            string rolls = "";
            for (int roll = 0; roll < numDice; roll++)
            {
                rolls += $"  {roll}: ";
                int rolled = Random.Range(1, diceSize + 1);
                rolls += $"{rolled}\n";
                total += rolled;
            }

            Debug.Log(rolls);
            Debug.Log($"Result: {total}");
            result.Value = total;
        }
        #endregion

        #region Private Functions

        #endregion

        #region Unity Specific Functions
        
        #endregion
    } 
}
