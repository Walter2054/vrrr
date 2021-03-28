using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting1 : MonoBehaviour
{ 
    public static shooting1 instance;
    public GameObject bullet;
    public GameObject target;
    // Start is called before the first frame update
    private void Awake()
    {
        instance=this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Shoot()
        {
         GameObject clone=Instantiate(bullet,transform.position,Quaternion.identity);
         clone.GetComponent<Rigidbody>().AddForce(transform.forward*5000);
         Destroy (clone, 3);
		}
    
}
