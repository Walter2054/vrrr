using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour
{
    public Image imGaze;
    public float totalTime=2;
    bool vrStatus;
    float vrTimer;
    public Transform teleport;
    public int distanceOfRay = 100;
    private RaycastHit hit;
   
    public int counter;
    public float timer;
    
    public void VrOn()
    {
        vrStatus = true;
    }

    public void VrOff()
    {
        vrStatus = false;
        vrTimer = 0;
        imGaze.fillAmount=0;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { timer = timer - Time.deltaTime;
        if (vrStatus)
        {
            vrTimer += Time.deltaTime;
            imGaze.fillAmount = vrTimer / totalTime;
        }

        Ray ray= Camera.main.ViewportPointToRay(new Vector3(0.5f,0.5f,0f));
        if(Physics.Raycast(ray,out hit, distanceOfRay))
        {  if(hit.transform.tag=="tp" && imGaze.fillAmount==1)
           {
            Debug.Log("hit");
            hit.transform.GetComponent<Teleport1>().Teleporting();
		   }
           if (hit.transform.tag== "Wall" && imGaze.fillAmount==1)
           {
           Debug.Log("Wall is hit");
           transform.GetComponent<PlayerWalk>().Move();
           
		   }
           if(hit.transform.tag=="target")
           {
             shooting1.instance.Shoot();
             Destroy(hit.transform.gameObject);
		   }
		}
	}
       /* if (imGaze.fillAmount == 1)
        {
        
            transform.position = new Vector3(teleport.position.x, teleport.position.y + 1.5f, teleport.position.z);
           
         }*/
    
}
