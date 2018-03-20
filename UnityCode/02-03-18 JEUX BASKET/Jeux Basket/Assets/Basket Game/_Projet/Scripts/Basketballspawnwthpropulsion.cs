using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basketballspawnwthpropulsion : BasketBallSpawner {

    [Header("Propulsion Params")]
    public Transform ForceDirection;
    public float ForceIntensity;
    public Vector3 Velocity;

    protected override void SpawnObject() {
        base.SpawnObject();
        Rigidbody rightbodyball = lastCreatedObject.GetComponent<Rigidbody>();
        if (rightbodyball != null)
        {
            Velocity = ForceDirection.forward * ForceIntensity;
            rightbodyball.AddForce(Velocity , ForceMode.Impulse);
        }
        else
        {
            Debug.LogWarning("tas  oublier de mettre un rigidbody ", this);
        }
        
    }
    public void Update()
    {
        base.Update();
        Velocity = ForceDirection.forward * ForceIntensity;
    }
}
