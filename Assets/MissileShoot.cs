using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileShoot : MonoBehaviour
{
    public float speed;
    public GameObject sphere;
    public Vector3 look;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.transform.forward * Time.deltaTime * speed;
        StartCoroutine(ExecuteAfterTime(1.5f));
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Orb")
        {
            Destroy(this.gameObject);
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        this.transform.LookAt(look);
    }
}