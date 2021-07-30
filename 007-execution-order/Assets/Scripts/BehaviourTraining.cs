using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourTraining : MonoBehaviour
{ 
    // Use this method before initialization
    private void Awake()
    {
        Debug.Log("This class is about to wake up");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This class is just started");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
    }
}
