using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotProjectile : ShotBase
{
    [SerializeField] private float speed;

    public override void Shot(GameObject projectile)
    {
        base.Shot(projectile);
        Rigidbody rigidbody = projectile.GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            
            rigidbody.AddForce(rigidbody.transform.forward * speed);
        }
    }
}
