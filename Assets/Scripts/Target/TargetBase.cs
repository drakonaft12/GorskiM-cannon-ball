using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TargetBase : MonoBehaviour
{
    public abstract bool HitResult(Collider other);
}
