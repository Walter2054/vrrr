using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnie : MonoBehaviour
{ public int health;
  public GameObject explosion;
  public static spawnie instance;

  public void Awake ()
  {
   instance = this;
  }

  public void GotHit()
  {
      health--;
  }

  public void Destroy()
  {
   Destroy(gameObject);
  }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health<=0) Destroy();
        {
        
		}
    }
}
