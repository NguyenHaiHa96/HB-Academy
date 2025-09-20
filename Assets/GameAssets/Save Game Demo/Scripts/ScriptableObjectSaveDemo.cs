using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaveGameDemo
{
    public class ScriptableObjectSaveDemo : MonoBehaviour
    {
        [SerializeField] private PlayerDataSaveData playerDataSaveData;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                SavePlayerData();
            }
        }
        
        public void SavePlayerData()
        {
            playerDataSaveData.playerName = "Ha";
            playerDataSaveData.level = 1;
            playerDataSaveData.health = 1;
            
        }
    }
}
