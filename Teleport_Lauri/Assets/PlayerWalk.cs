using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{   
    public float walkinSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
	  //transform.position=transform.position + Camera.main.transform.forward *walkinSpeed* Time.deltaTime;
        
    }
    public void Move()
    {
    transform.position=transform.position + Camera.main.transform.forward *walkinSpeed* Time.deltaTime;
	}
}
