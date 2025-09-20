using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoveStopMoveDemo
{
    public class AttackRange : MonoBehaviour
    {
        [SerializeField] private Character owner;
        
        public void Setup(Character character)
        {
            owner = character;
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Character")) return;
            Character target = other.GetComponent<Character>();
            if (target == null) return;
            if (target.IsDead || target == owner) return;
            owner.AddTarget(target);
        }
        
        private void OnTriggerExit(Collider other)
        {
            if (!other.CompareTag("Character")) return;
            Character target = other.GetComponent<Character>();
            if (target == null) return;
            owner.RemoveTarget(target);
        }
    }
}

