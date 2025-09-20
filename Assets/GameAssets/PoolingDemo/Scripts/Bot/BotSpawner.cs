using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PoolingDemo
{
    public class BotSpawner : MonoBehaviour
    {
        [SerializeField] private int botCount = 10;

        private float _xStep = 2f;
        
        private void Start()
        {
            Vector3 spawnPosition = transform.position;
            for (int i = 0; i < botCount; i++)
            {
                Bot bot = HBPool.Spawn<Bot>(PoolType.Bot, spawnPosition, Quaternion.identity);
                spawnPosition.x += _xStep; 
            }
        }
    }
}

