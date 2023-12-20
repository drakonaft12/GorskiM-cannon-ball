using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TargetBase : MonoBehaviour
{
    [SerializeField] private float life = 100;
    public abstract bool HitResult(Collider other);

    public virtual void LifeReact(float damage)
    {
        life -= damage;
        if (life <= 0f)
        {
            gameObject.SetActive(false);
        }
    }
}
