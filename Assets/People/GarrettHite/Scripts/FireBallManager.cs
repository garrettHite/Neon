using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonGame
{
    public class FireBallManager : MonoBehaviour
    {
        public GameObject fireBallRed;
        public GameObject fireBallBlue;
        public GameObject spawnPoint;
        public float startTime = 90f;
        public float spawnTime = 10f;
        public int numPro;
        int i = 0;
        public bool redBlue;

        void Start()
        {
            InvokeRepeating("NewFireBallSet", startTime, spawnTime);
        }

        void Update()
        {
            
        }

        void NewFireBallSet()
        {
            StartCoroutine("fire");
        }

        IEnumerator fire()
        {
            while(i < numPro)
            {
                i = i + 1;
                Vector3 spawnPosition = spawnPoint.transform.position;
                Quaternion spawnRotation = spawnPoint.transform.rotation;
                if (redBlue == true)
                {
                    GameObject newFireBall = Instantiate(fireBallRed, spawnPosition, spawnRotation);
                    redBlue = false;
                }
                else
                {
                    GameObject newFireBall = Instantiate(fireBallBlue, spawnPosition, spawnRotation);
                    redBlue = true;
                }
                yield return new WaitForSeconds(0.25f);
            }
            i = 0;
        }
    }
}
