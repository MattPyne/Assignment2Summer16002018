using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class WeaponObjects : ScriptableObject
{

    public float DamageLevel = 10;

    public float DoDamage()
    {
        return DamageLevel;
    }
}
