using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bombFactory;
    public GameObject firePoint;
    public float power = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject bomb = Instantiate(bombFactory, firePoint.transform.position, Quaternion.identity);
            Rigidbody rb = bomb.GetComponent<Rigidbody>();

            // rb.AddForce(Camera.main.transform.forward * power , ForceMode.Impulse);
            Vector3 dir = Camera.main.transform.forward + (Camera.main.transform.up * 0.5f);
            dir.Normalize();
            rb.AddForce(dir * power, ForceMode.Impulse);
        }
    }
}
