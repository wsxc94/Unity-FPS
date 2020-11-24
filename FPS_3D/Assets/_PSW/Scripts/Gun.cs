using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private RaycastHit hit;
    public GameObject effectFactoty = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                Debug.Log("hit point : " + hit.point + ", distance : " + hit.distance + ", name : " + hit.collider.name);
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);

                GameObject ef = Instantiate(effectFactoty , hit.point , Quaternion.identity);
               
                
            }
        }
        
        //else {
        //    Debug.DrawRay(transform.position, transform.forward * 1000f, Color.red);
        //}

   
    }
}
