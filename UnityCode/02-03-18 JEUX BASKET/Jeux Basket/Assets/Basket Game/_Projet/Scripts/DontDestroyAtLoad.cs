using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAtLoad : MonoBehaviour {


    public float _dieAfter=10f;

	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(this.gameObject);
        Destroy(this.gameObject, _dieAfter);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
