using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonGame
{
    public class ShootBullet : MonoBehaviour
    {
        public Button button;
        public GameObject bullet;
        public float speed;
        public GameObject fireBall;
        void Shoot()
        {
            GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            Rigidbody newBulletRigidBody = newBullet.GetComponent<Rigidbody>();
            newBulletRigidBody.AddForce(Vector3.forward * speed);

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("RTriggerPress"))
            {
                Shoot();
            }
        }

        //private void OnCollisionEnter(Collision col)
        //{
        //    if (col.gameObject == fireBall)
        //    {
        //        Destroy(this.gameObject);
        //        Destroy(col.gameObject);
        //    }
        //}
    }
}

