using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatProgectil : CreateBase
{
    public override void Reload(int index)
    {
        getObjects[index].GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
