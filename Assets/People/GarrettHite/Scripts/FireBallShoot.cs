using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallShoot : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.transform.forward * Time.deltaTime * speed;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Orb")
        {
            Destroy(this.gameObject);
        }
    }
}
