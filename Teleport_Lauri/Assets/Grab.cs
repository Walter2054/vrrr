using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{ 
    public GameObject ball,hand;
    bool inHands=false;
    Vector3 ballposition;
    // Start is called before the first frame update
    void Start()
    {
       ballposition= ball.transform.position;
       ball.transform.localPosition = ballposition;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (!inHands)
        {
        ball.transform.SetParent(hand.transform);
        ball.transform.localPosition = new Vector3(0f,-0.9f,0f);
        inHands=true;
        }


         else if (inHands)
        {
        ball.transform.SetParent(null);
        ball.transform.localPosition = ballposition;
        inHands=false;
		} 
	        
    }
}
