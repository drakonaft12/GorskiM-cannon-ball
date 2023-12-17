using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetProjectile : TargetBase
{
    [SerializeField] private SchetController schet;
    [SerializeField] private int addSchet = 10;
    private void OnCollisionEnter(Collision collision)
    {
        HitResult(collision.collider);
    }
    public override bool HitResult(Collider other)
    {
        if (other == null)
        {
            return true;
        }
        schet.AddSchet(addSchet);
        return false;
    }

    
}
