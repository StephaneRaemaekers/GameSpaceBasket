using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererTrajectory : MonoBehaviour {

    public LineRenderer lineRenderer;
    public Basketballspawnwthpropulsion BallSpawner;
    public int Step = 10;
    public float StepDistance = 0.2f;


    public Vector3 CalculPosition(Vector3 PostionInitial, Vector3 VelocityInitial, Vector3 Gravity, float Time)
    {
        Vector3 P = PostionInitial + VelocityInitial * Time + 0.5f *Gravity * Time * Time;

        return P;
    }

    public void MethodeLineRender()
    {
        float time= 0 ;

       for (int i = 0; i < lineRenderer.positionCount ; i++)
        {
            Vector3 Postion = CalculPosition(BallSpawner.spawnpoint.position, BallSpawner.Velocity, Physics.gravity, time);
            time += StepDistance;
            lineRenderer.SetPosition(i, Postion);
        }
    }

    public void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = Step;
    }

    void Update()
    {
        MethodeLineRender();
    }
}
