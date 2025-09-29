using UnityEngine;
using Sirenix.OdinInspector;

namespace PackagesDemo
{
    [GUIColor(0.1f, 0.6f, 0.1f)]
    public enum EOdinItemType
    {
        None = 0,
        Coin = 1,
        Gem = 2,
    }
    
    [CreateAssetMenu(fileName = "OdinItemDataConfig", menuName = "Scriptable Objects/Odin Item Data Config", order = 0)]
    public class OdinItemDataConfig : ScriptableObject
    {
        public string id;
        public EOdinItemType type;
        [PreviewField(80, ObjectFieldAlignment.Center)]
        public Sprite sprIcon;
        public bool canStack;
        [ShowIf(nameof(CanStack))] public int maxStack;
        
        private bool CanStack() => canStack;
    }
}