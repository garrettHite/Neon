using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "FireBallBlue(Clone)" || col.gameObject.name == "MissileBlue(Clone)")
        {
            Destroy(col.gameObject);
        }
    }
}
