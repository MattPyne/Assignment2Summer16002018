using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpOrDownBase : ScriptableObject
{

    public Player AnyPlayer;
    public float PowerLevel = 1.0f;

    public void RunPowerUp()
    {
        AnyPlayer.Health += PowerLevel;
        AnyPlayer.Ammo += PowerLevel;
        AnyPlayer.Jump += PowerLevel;
    }
    
}
