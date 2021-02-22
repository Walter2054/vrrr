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
    public void VrOn()
    {
        vrStatus = true;
    }

    public void VrOff()
    {
        vrStatus = false;
        vrTimer = 0;
        imGaze.fillAmount = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vrStatus)
        {
            vrTimer += Time.deltaTime;
            imGaze.fillAmount = vrTimer / totalTime;
        }

        if (imGaze.fillAmount == 1)
        {
            transform.position = new Vector3(teleport.position.x, teleport.position.y + 1.5f, teleport.position.z);
        }
    }
}
