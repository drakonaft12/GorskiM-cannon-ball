using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReducerLimitAxis : ReducerAxis
{
    [SerializeField] private Vector2 max;
    [SerializeField] private Vector2 min;

    public override void Rotate(Vector2 vector)
    {
        Vector2 lim = returnCurrent;
        
        if(lim.x <= max.x && lim.y <= max.y && lim.x >= min.x && lim.y >= min.y)
        {
            base.Rotate(vector);
        }
        else
        {
            var grY = Math.Clamp(lim.y, min.y, max.y);
            vector.y = grY == lim.y ? vector.y : 0;
            var grX = Math.Clamp(lim.x, min.x, max.x);
            vector.x = grX == lim.x ? vector.x : 0;
            returnCurrent = new Vector2(grX, grY);

            base.Rotate(vector);
        }
    }
}
