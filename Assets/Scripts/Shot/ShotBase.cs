using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShotBase : MonoBehaviour
{
    [SerializeField] private Transform pointShot;


    public virtual void Shot(GameObject projectile)
    {
        projectile.SetActive(true);
        projectile.transform.position = pointShot.position;
        projectile.transform.rotation = pointShot.rotation;

    }
}
