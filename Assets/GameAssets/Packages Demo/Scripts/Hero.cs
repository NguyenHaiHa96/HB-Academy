using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace PackagesDemo
{
    public class Hero : MonoBehaviour
    {
        [FoldoutGroup("Stats")]
        public string id;

        [FoldoutGroup("Stats"), Range(0, 100)]
        public int health;

        [FoldoutGroup("Abilities"), ListDrawerSettings(ShowIndexLabels = true)]
        public string[] skills;

        [Button]
        private void Heal() => health = 100;
        
        [ShowInInspector] private Dictionary<string, int> _inventory = new();
    }
}