using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoveStopMoveDemo
{
    [CreateAssetMenu(fileName = "PantDataVer1", menuName = "Scriptable Objects/Pant Data Ver 1", order = 1)]
    public class PantDataConfigVer1 : ScriptableObject
    {
        [SerializeField] private List<Material> materials;

        public Material GetPant(PantType pantType)
        {
            return materials[(int)pantType];
        }
    }

    public enum PantType
    {
        None = 0,
        Pant1 = 1,
        Pant2 = 2,
        Pant3 = 3,
        Pant4 = 4,
        Pant5 = 5,
        Pant6 = 6,
        Pant7 = 7,
        Pant8 = 8,
        Pant9 = 9,
    }
}
