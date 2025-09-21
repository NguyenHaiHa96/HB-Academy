using UnityEngine;
using UnityEngine.Serialization;
using SlopeMovementDemo;

namespace BridgeRace
{
    public class ColorObject : MonoBehaviour
    {
        public EColorType colorType;
        [SerializeField] private ColorData colorData;
        [SerializeField] private Renderer ren;
        
        public void ChangeColor(EColorType type)
        {
            colorType = type;
            ren.material = colorData.GetColorMat(type);
        }
    }
}