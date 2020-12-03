using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    public Vector3 position;
    public Vector3 rotation;
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        this.transform.Rotate(rotation * Time.deltaTime);
    }
}
