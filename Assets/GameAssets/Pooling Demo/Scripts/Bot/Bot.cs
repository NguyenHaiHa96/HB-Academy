using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace PoolingDemo
{
    public class Bot : GameUnit
    {
        [SerializeField] private NavMeshAgent agent;
        [SerializeField] private int brickRequired;
        private IState<Bot> _currentState;
        private Vector3 _targetPosition;
        
        private int _collectedBrick;
        
        private void Start()
        {
            ChangeState(new BotPatrolState());
        }

        private void Update()
        {
            _currentState?.OnExcute(this);
        }
        
        public void ChangeState(IState<Bot> newState)
        {
            _currentState?.OnExit(this);
            _currentState = newState;
            _currentState.OnEnter(this);
        }

        public void SeekingBrick()
        {
            // Brick <- Stage <- Level <- LevelManager
            // Tim gach cung mau o Stage dang dung
            // _targetPosition = LevelManager.Ins.GetBrickPosition(colorData);
            agent.SetDestination(_targetPosition);
        }

        public bool HasMeetedBrickCondition()
        {
            // tim du so luong de di xay cau
            return _collectedBrick >= brickRequired;
        }

        public bool IsReachedTarget()
        {
            return Vector3.Distance(transform.position, _targetPosition) <= 1f;
        }
    }
}

