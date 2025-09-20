using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoveStopMoveDemo
{
    [CreateAssetMenu(fileName = "PantDataVer2", menuName = "Scriptable Objects/Pant Data Ver 2", order = 1)]
    public class PanDataConfigVer2 : ScriptableObject
    {
        [SerializeField] private List<PantData> pantDatas;

        public PantData GetPant(int id)
        {
            return pantDatas.Find(pant => pant.id == id);
        }
    }

    [Serializable]
    public class PantData
    {
        public int id;
        public Material material;
    }
}
