using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject[] enemies;
    public  float min_X=-2.6f,max_X=2.6f;
    public float delayTimer=0.5f;
    private float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;
        if(timer<=0){
            Vector3 temp=this.transform.position;
            temp.x=Random.Range(min_X,max_X);
            int rand=Random.Range(0,4);
            Instantiate(enemies[rand], temp, enemies[rand].transform.rotation);
        timer=delayTimer;
        }
    }
}
