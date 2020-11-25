using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject fxFactory; //이펙트 프리팹


    private void OnCollisionEnter(Collision collision)
    {
        GameObject fx = Instantiate(fxFactory, transform.position, Quaternion.identity);


        Destroy(gameObject);
           
            
    }


}
