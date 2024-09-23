using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{private Renderer r;
public float speed=0.5f;
private Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        r=this.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {offset=new Vector2(0f , Time.time*speed);
    r.material.mainTextureOffset=offset;
        
    }
}
