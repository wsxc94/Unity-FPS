using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private RaycastHit hit;
    public GameObject effectFactoty = null;
    public float damage = 1f;
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
                //Debug.Log("hit point : " + hit.point + ", distance : " + hit.distance + ", name : " + hit.collider.name);
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);

                if (hit.collider == null) return;
                if (hit.collider.CompareTag("Enemy"))
                {
                hit.transform.GetComponent<EnemyFSM>().RayCastHit(damage, hit.point);
                }

                //object[] _param = new object[2];
                //_param[0] = hit.point;
                //_param[1] = damage;
                //hit.collider.gameObject.SendMessage("RayCastHit", _param, SendMessageOptions.DontRequireReceiver);

                GameObject ef = Instantiate(effectFactoty , hit.point , Quaternion.identity);
               
                
            }
        }
        
        //else {
        //    Debug.DrawRay(transform.position, transform.forward * 1000f, Color.red);
        //}

   
    }
}
