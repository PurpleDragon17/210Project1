using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InvetTrack : MonoBehaviour

    
{
    public static bool PBox;
    public TMP_Text Slot1;
    public GameObject Menu;


    // Start is called before the first frame update
    void Start()
    {
        PBox = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(PBox == true)
        {
            Slot1.text = "Got it";
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            SceneManager.LoadScene("Pockets");

        }
    }
}
