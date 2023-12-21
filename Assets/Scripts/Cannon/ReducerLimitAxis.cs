using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReducerLimitAxis : ReducerAxis
{
    [SerializeField] private LimitAxis limitX;
    [SerializeField] private LimitAxis limitY;

    public override void Rotate(Vector2 vector)
    {

        vector.y = limitY.Limit(returnCurrent.y + vector.y * coeff.y) ? vector.y : 0f;  
        vector.x = limitX.Limit(returnCurrent.x + vector.x * coeff.x) ? vector.x : 0f;
        returnCurrent = new Vector2(limitX.rf, limitY.rf);
        base.Rotate(vector);
        
    }
}

[Serializable]
public struct LimitAxis
{
    public float min;
    public float max;
    public float rf;

    public bool Limit(float value)
    {
        rf = Math.Clamp(value, min, max);
        if (min < value && value < max) return true;
        return false;
    }
}
