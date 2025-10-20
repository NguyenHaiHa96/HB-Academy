using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponDataConfig", menuName = "Scriptable Objects/Weapon Data Config", order = 1)]
public class WeaponDataConfig : ScriptableObject
{
    public List<WeaponData> weapons;
}

[Serializable]
public class WeaponData
{
    public string name;
    public EWeaponType type;
    public int cost;
    public int ads;
}

public enum EWeaponType
{
    Hammer01 = PoolType.Hammer01,
    Hammer02 = PoolType.Hammer02,
    Hammer03 = PoolType.Hammer03,
    Candy01 = PoolType.Candy01,
    Candy02 = PoolType.Candy02,
    Candy03 = PoolType.Candy03
}