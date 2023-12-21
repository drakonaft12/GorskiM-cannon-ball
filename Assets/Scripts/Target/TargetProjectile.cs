using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TargetProjectile : TargetBase
{
    [SerializeField] private SchetController schet;
    [SerializeField] private int addSchet = 10;

    private void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.HSVToRGB(addSchet/100f, 1, 1);
    }
    private void OnCollisionEnter(Collision collision)
    {
        HitResult(collision.collider);
        var pos = transform.position + (transform.position - collision.transform.position)*(Random.Range(0,1)==1?-1:1 * Random.Range(0.5f, 1.5f));
        transform.DOMove(pos, 0.2f);
        LifeReact(10);
        
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
