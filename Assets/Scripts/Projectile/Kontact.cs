using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kontact : MonoBehaviour
{
    [SerializeField]private ParticleSystem particls;
    [SerializeField]private float speedParticls = 10;

    private Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        particls.startSpeed = speedParticls;
    }
    public void OnDisable()
    {
        particls.Stop();
        particls.startSpeed = speedParticls;
    }

    

    private void OnCollisionEnter(Collision collision)
    {
        particls.Stop();
        particls.gameObject.transform.position = collision.contacts[0].point;
        particls.startSpeed = rigidbody.velocity.magnitude;
        particls.Play();
    }

}
