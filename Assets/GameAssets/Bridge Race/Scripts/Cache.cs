using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BridgeRace
{
    public class Cache
    {
        private static Dictionary<Collider, Character> _characterDictionary = new Dictionary<Collider, Character>();
        private static Dictionary<Collider, Stair> _stairDictionary = new Dictionary<Collider, Stair>();
        
        public static Character GetCharacter(Collider collider)
        {
            if (!_characterDictionary.ContainsKey(collider))
            {
                _characterDictionary.Add(collider, collider.GetComponent<Character>());
            }

            return _characterDictionary[collider];
        } 

        public static Stair GetStair(Collider collider)
        {
            if (!_stairDictionary.ContainsKey(collider))
            {
                _stairDictionary.Add(collider, collider.GetComponent<Stair>());
            }

            return _stairDictionary[collider];
        }
    }
}