using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : InputBase
{

    [SerializeField] private Rotatebase rotatebase;
    [SerializeField] private float rotationSpeed;
    public override void Control()
    {
        rotatebase.Rotate(
            new Vector2(
                Input.GetAxis("Horizontal"),
                 Input.GetAxis("Vertical")
                 ) * Time.deltaTime * rotationSpeed);
    }
}
   
