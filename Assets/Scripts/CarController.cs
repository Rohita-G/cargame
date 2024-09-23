using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
private float min_X=-2.7f,max_X=2.7f;
    public  float speed=10f;
    private Vector3 myPosition;
    // Start is called before the first frame update
    void Start()
    {
        myPosition=this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      myPosition.x+=Input.GetAxis("Horizontal")*speed*Time.deltaTime;  
      if(myPosition.x>max_X){
        myPosition.x=max_X;
      }
      if(myPosition.x<min_X){
    myPosition.x=min_X;
} 
this.transform.position=myPosition;
    }
private void OnTriggerEnter2D(Collider2D collision){
if(collision.gameObject.tag=="Enemy"){
    UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
}
}
}

