using UnityEngine;

namespace PackagesDemo
{
    public enum EItemType
    {
        None = 0,
        Coin = 1,
        Gem = 2,
    }
    
    [CreateAssetMenu(fileName = "ItemDataConfig", menuName = "Scriptable Objects/Item Data Config")]
    public class ItemDataConfig : ScriptableObject
    {
        public string id;
        public EItemType type;
        public Sprite sprIcon;
        public bool canStack;
        public int maxStack;
    }
}

