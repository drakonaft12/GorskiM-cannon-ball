using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputBase : MonoBehaviour
{

    public abstract void Control();
    void Update()
    {
        Control();
    }
}
