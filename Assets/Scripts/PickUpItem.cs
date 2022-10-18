using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddToInventory();
        }
    }

    public void AddToInventory()
    {
            if(InvetTrack.PBox == false)
            {
                InvetTrack.PBox = true;
            }
        Destroy(gameObject);
    }

}
