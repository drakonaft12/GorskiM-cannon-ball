using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TargetBase : MonoBehaviour
{
    [SerializeField] private float MaxHP = 100f;
    private float life;
    public abstract bool HitResult(Collider other);

    public virtual void LifeReact(float damage)
    {
        life -= damage;
        if (life <= 0f)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        RestoreLife();
    }

    public void RestoreLife()
    {
        life = MaxHP;
    }
    
}
