using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BridgeRace
{
    public class JoystickController : MonoBehaviour
    {
        [SerializeField] private DynamicJoystick joystick;

        private void Update()
        {
            Debug.Log(GetInputDirection());
        }

        public Vector2 GetInputDirection()
        {
            return new Vector2(joystick.Horizontal, joystick.Vertical);
        }
    }
}

