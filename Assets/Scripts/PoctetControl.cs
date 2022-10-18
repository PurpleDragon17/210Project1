using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoctetControl : MonoBehaviour
{
    public GameObject ItemSlot1;

    // Start is called before the first frame update
    void Start()
    {
        ItemSlot1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (InvetTrack.PBox == true)
        {
            ItemSlot1.SetActive(true);
        }
    }
}
