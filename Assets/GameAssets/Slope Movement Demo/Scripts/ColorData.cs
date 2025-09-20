using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlopeMovementDemo
{
    [CreateAssetMenu(fileName = "ColorData", menuName = "Scriptable Objects/ColorData", order = 1)]
    public class ColorData : ScriptableObject
    {
        [SerializeField] Material[] colorMats;

        public Material GetColorMat(EColorType colorType)
        {
            return colorMats[(int)colorType];
        }
    }

}
