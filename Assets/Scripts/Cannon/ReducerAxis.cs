using UnityEngine;
using UnityEngine.UIElements;

public class ReducerAxis : Rotatebase
{

[SerializeField]
    private Vector2 coeff = Vector2.one;


    public override void Rotate(Vector2 vector)
    {
        base.Rotate(vector * coeff);
    }
}