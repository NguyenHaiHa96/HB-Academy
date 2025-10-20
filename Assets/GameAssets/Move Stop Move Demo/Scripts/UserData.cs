using System;
using System.Collections.Generic;

namespace MoveStopMoveDemo
{
    [Serializable]
    public class UserData
    {
        public int level;
        public int coin;
        public EWeaponType equippedWeapon;
        public List<EWeaponType> unlockedWeapons;
    }
}