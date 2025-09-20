using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PoolingDemo
{
    public class Bot : GameUnit
    {
        private IState<Bot> _currentState;
        
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
    }
}

