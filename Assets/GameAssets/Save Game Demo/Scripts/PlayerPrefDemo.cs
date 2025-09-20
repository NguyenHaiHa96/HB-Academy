using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaveGameDemo
{
    public class PlayerPrefDemo : MonoBehaviour
    {
        private const string STR_USER_NAME = "UserName";
        private const string STR_USER_SCORE = "UserScore";
        
        [SerializeField] private string userName;
        [SerializeField] private int userScore;
        
        private void Start()
        {
            PlayerPrefs.SetString(STR_USER_NAME, "Ha");
            PlayerPrefs.SetInt(STR_USER_SCORE, 5);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                GetPlayerPrefsData();
            }
        }

        private void GetPlayerPrefsData()
        {
            userName = PlayerPrefs.GetString(STR_USER_NAME, String.Empty);
            userScore = PlayerPrefs.GetInt(STR_USER_SCORE, 0);
        }
    }
}

