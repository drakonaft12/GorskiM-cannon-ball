using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespavnTarget : CreateBase
{
    public override void Reload(int index)
    {
        getTime[index] = 0;
    }

    public override void ControlObject()
    {
        if (getObjects != null && Time.frameCount % getDeltaLife == 0)
        {
            for (int i = 0; i < getObjects.Count; i++)
            {
                if (getTime[i] < getTimeLife) { getTime[i]++; }
                else { Active(i, true); }
                if (getObjects[i] != getActive[i])
                {
                    Active(i, false);
                }
            }
        }
    }

}
