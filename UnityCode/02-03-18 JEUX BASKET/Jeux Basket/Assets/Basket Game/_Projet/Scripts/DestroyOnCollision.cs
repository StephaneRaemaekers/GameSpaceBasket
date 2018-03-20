using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollision : MonoBehaviour {

    public string _menuName="MenuScene";
    public GameObject prefabToCreateOnDestroy;
    public float destroyPrefAfter=3;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
    
          
            SceneManager.LoadScene(_menuName);
           // print("score");
        }
        if (collision.gameObject.tag == "BasketBall")
        {
           
            Destroy(this.gameObject,0.01f);
            ScoreManager.instance.score++;
            
            if (prefabToCreateOnDestroy != null)
            {
                GameObject createdPrefab = Instantiate(prefabToCreateOnDestroy, this.transform.position, transform.rotation);
                Destroy(createdPrefab, destroyPrefAfter);
              
            }
        }

    }
}
