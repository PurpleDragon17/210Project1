using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycats : MonoBehaviour
{
    public Transform Eyeballs;
    public float EyeSpin;
    
   



    // Start is called before the first frame update
    void Start()
    {


      
    }
    // Update is called once per frame
    void Update()
    {
        float mouseInputY = Input.GetAxis("Mouse Y");
        EyeSpin = mouseInputY;
        //EyeSpin = Mathf.Clamp(EyeSpin, -90f, 90f);
       // transform.rotation = Quaternion.Euler(new Vector3(EyeSpin, 0f, 0f));

        float mouseInputX = Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(transform.eulerAngles + new Vector3(EyeSpin, mouseInputX, 0f));
       

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Eyeballs.position, Eyeballs.forward, out hit))
            {
               Transform hip = hit.collider.GetComponent<Transform>();
                Debug.Log(hip.position);

            }

        }
    }
}


