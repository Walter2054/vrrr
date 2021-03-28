using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject enemy; 
    private int xPos, zPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (EnemySpawnCO());
    }

    // Update is called once per frame
    void Update()
    { 
       
    }
    IEnumerator EnemySpawnCO()
     {   
        while (true)
        { 
        
            xPos = (int) Random.Range(transform.position.x,transform.position.x*10);
            zPos = (int) Random.Range(transform.position.z,transform.position.z*10);
            Instantiate (enemy, new Vector3(xPos, transform.position.y,zPos),Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
        }   
    }
}
