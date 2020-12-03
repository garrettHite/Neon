using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonGame
{
    public class Interactable_LerperWithCoroutines : Interactable
    {
        public Transform lerpTo;
        public Transform lerpFrom;
        public Transform target;
        Coroutine C;

        public float speed;

        void Start()
        {
            C = StartCoroutine(MoveTo());
        }

        IEnumerator MoveTo()
        {
            float counter = 0;
            Vector3 startPosition = target.position;
            while(counter < 1)
            {
                counter += Time.deltaTime/speed;
                target.transform.position =   Vector3.Lerp(lerpFrom.position, lerpTo.position, counter);
                yield return null;
            }

        }
    }

}