using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnimationDemo
{
    public class AnimationCurveDemo : MonoBehaviour
    {
        public AnimationCurve moveCurve; 
        public float duration;      
        public float distance;     

        private float _timer = 0f;
        private Vector3 _startPos;

        void Start()
        {
            _startPos = transform.position;
        }

        void Update()
        {
            if (_timer < duration)
            {
                _timer += Time.deltaTime;
                float t = Mathf.Clamp01(_timer / duration);           
                float curveValue = moveCurve.Evaluate(t);            
                float moveAmount = curveValue * distance;           
                transform.position = _startPos + transform.forward * moveAmount;
            }
        }
    }
}

