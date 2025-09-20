using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlopeMovementDemo
{
    public class ColorObject : GameUnit
    {
        public EColorType colorType;

        [SerializeField] private ColorData colorData;
        [SerializeField] private Renderer renderer;

        public void ChangeColor(EColorType type)
        {
            colorType = type;
            renderer.material = colorData.GetColorMat(colorType);
        }
    }

    public enum EColorType
    {
        Default, 
        Black, 
        Red, 
        Blue, 
        Green, 
    }
}

