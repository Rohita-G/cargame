using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{public float speed=8f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp=this.transform.position;
        temp.y-=speed*Time.deltaTime;
        this.transform.position=temp;
        if (this.transform.position.y<-7){
            gameObject.SetActive(false);
        }
    }
}
