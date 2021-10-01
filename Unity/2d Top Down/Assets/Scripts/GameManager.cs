using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool hasKey;
    public bool isDoorLocked;

    

    // Start is called before the first frame update
    void Start()
    {
        hasKey = false;
        isDoorLocked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(hasKey && !isDoorLocked)
        {
            print("You go bruh and ascend into oblivion");
        }
    }
}
