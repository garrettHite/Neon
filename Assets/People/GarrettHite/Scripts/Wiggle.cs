using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wiggle : MonoBehaviour
{
    public float Angle;
    public float Frequency;
    public float speed;

    void Start()
    {

    }

    // Update is called once per frame
   
    void Update()
    {
        speed = speed + Time.deltaTime;
        float phase = Mathf.Sin(speed / Frequency) * Angle;
        this.transform.localEulerAngles = new Vector3(phase, 5, 0);
    }


}
