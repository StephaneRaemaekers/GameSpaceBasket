using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamerawithHouse : MonoBehaviour {

    public Transform _cameraToAffect;
    public float _horizonalDigreeRotation = 90;

    [Header("Debug")]
    public Vector3 _positionMouse;
    public float _horizonPourcent;

    public float _verticalDigreeRotation = 90;
    public float _verticalPourcent;
	
	// Update is called once per frame
	void Update () {

#if UNITY_EDITOR
        float horizonPourcent = Input.mousePosition.x / Screen.width;

        horizonPourcent -= 0.5f;
        horizonPourcent *= 2f;
       // Debug.Log("pourcent = " + horizonPourcent);
        horizonPourcent = Mathf.Clamp(horizonPourcent, -1f, 1f);
        _horizonPourcent = horizonPourcent;
        _positionMouse = Input.mousePosition;


        float verticalPourcent = Input.mousePosition.y / Screen.height;

        verticalPourcent -= 0.5f;
        verticalPourcent *= 2f;
        //Debug.Log("pourcent = " + verticalPourcent);
        verticalPourcent = Mathf.Clamp(verticalPourcent, -1f, 1f);



        _cameraToAffect.localRotation = Quaternion.Euler(new Vector3(-1 * _verticalDigreeRotation * verticalPourcent, _horizonalDigreeRotation * horizonPourcent, 0));

        _verticalPourcent = verticalPourcent;
        _positionMouse = Input.mousePosition;


#endif

    }
}
