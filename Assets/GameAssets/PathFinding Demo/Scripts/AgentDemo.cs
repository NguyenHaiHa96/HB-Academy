using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace PathFindingDemo
{
    public class AgentDemo : MonoBehaviour
    {
        [SerializeField] private Camera mainCamera;
        [SerializeField] private NavMeshAgent navMeshAgent;
        [SerializeField] private Transform targetPoint;
        
        private RaycastHit _hit;
        
        private void Start()
        {
            mainCamera = Camera.main;
        }

        private void Update()
        {
            ClickToMove();
        }
        
            
        private void ClickToMove()
        {
            if (Input.GetMouseButtonDown(0))
            {
                navMeshAgent.SetDestination(targetPoint.position);
            }
        }
    }
}

