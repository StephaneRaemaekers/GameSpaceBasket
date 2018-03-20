using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAera : MonoBehaviour {


    public void Start()
    {

        ScoreManager.instance.score = 0;
    }

    private void OnTriggerEnter(Collider col)
    {
   
            ScoreManager.instance.score++;
   
    }

 


    
}
