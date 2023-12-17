using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputShot : PlayerInput
{
    [SerializeField] private ShotBase shotBase;
    [SerializeField] private CreatProgectil creatProgectil;
    [SerializeField] private float time;

    private float ti = 0;
    public override void Control()
    {
        base.Control();
        if (ti > 0) { ti -= Time.deltaTime; }
        else
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        { 
            shotBase.Shot(creatProgectil.AddObject());
            ti = time;
        }
        
    }
 
}
