using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mush : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   Vector3 position= new Vector3(4, 0 , 0);
        float aleatoire = Random.value;
        Debug.Log(aleatoire);
        if(aleatoire<0.5){
            transform.position += position;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
