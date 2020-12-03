using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bounce : MonoBehaviour
{
    public float height;
    public float speedBounce;
    public float distance;
    public float length;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localPosition = new Vector3(distance, Mathf.Sin(Time.time * speedBounce) * height, length);
    }
}
