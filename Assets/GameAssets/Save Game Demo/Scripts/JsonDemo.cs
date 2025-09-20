using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

namespace SaveGameDemo
{
    public class JsonDemo : MonoBehaviour
    {
        private const string STR_KEY_USER_DATA = "UserData";
        
        [SerializeField] private UserData userData;
        
        public void LoadUserData()
        {
            string saveData = PlayerPrefs.GetString(STR_KEY_USER_DATA, 
                string.Empty);
            if (!string.IsNullOrEmpty(saveData))
            {
                userData = JsonConvert.DeserializeObject<UserData>(saveData, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                });
            }
            else
            {
                userData = new UserData();
                SaveUserData();
            }
        }
        
        public void SaveUserData()
        {
            string saveData = JsonConvert.SerializeObject(userData, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
            PlayerPrefs.SetString(STR_KEY_USER_DATA, saveData);
        }
    }

    [Serializable]
    public class UserData
    {
        public CampaignData campaignData;
        
        public UserData()
        {
            campaignData = new CampaignData();
        }
    }

    [Serializable]
    public class CampaignData
    {
        public int bestWave;

        public CampaignData()
        {
            bestWave = 1;
        }
    }
} 

