using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SaveGameDemo
{
    public class ScriptableObjectDemo : MonoBehaviour
    {
        [SerializeField] private EnemyDataConfig enemyDataConfig;
        [SerializeField] private Image imgIcon;
        [SerializeField] private TextMeshProUGUI txtId;
        [SerializeField] private TextMeshProUGUI txtHealth;

        private void Start()
        {
            imgIcon.sprite = enemyDataConfig.sprIcon;
            txtId.SetText($"ID: {enemyDataConfig.id}");
            txtHealth.SetText($"Health: {enemyDataConfig.health}");
        }
    }
}
