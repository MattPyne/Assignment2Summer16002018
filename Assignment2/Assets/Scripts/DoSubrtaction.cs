using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoSubrtaction : ScriptableObject
{

    public int c;

    private void OnEnable()
    {
        c = Run(10, 3);
    }

    public int Run(int a, int b)
    {
        return a -= b;
    }
}
