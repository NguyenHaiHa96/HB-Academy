using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoveStopMoveDemo
{
    public class Character : MonoBehaviour
    {
        public Action<Character> onCharacterDead;
        
        [SerializeField] private AttackRange attackRange;
        [SerializeField] private List<Character> targets = new();
        [SerializeField] private bool isDead;
        
        public bool IsDead
        {
            get => isDead;
            set => isDead = value;
        }

        private void Start()
        {
            attackRange.Setup(this);
        }

        public void AddTarget(Character target)
        {
            if (targets.Contains(target)) return;
            targets.Add(target);
            target.onCharacterDead += RemoveTarget;
        }
        
        public void RemoveTarget(Character target)
        {
            if (!targets.Contains(target)) return;
            targets.Remove(target);
            target.onCharacterDead -= RemoveTarget;
        }

        private void OnDisable()
        {
            onCharacterDead?.Invoke(this);
        }
    }
}