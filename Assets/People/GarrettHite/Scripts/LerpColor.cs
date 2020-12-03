using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonGame
{
    public class LerpColor : MonoBehaviour
    {
        public float lerpTime;
        private Color myColor;
        Color EmissionColor;
        float emission;
        
        void Start()
        {
            //gameObject.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        }

        // Update is called once per frame
        void Update()
        {
            //cubeMeshRenderer.material.color = Color.Lerp(cubeMeshRenderer.material.color, myColor, lerpTime);
            //EmissionColor = cubeMeshRenderer.material.color;
            gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.Lerp(Color.black, myColor, lerpTime));
            gameObject.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        }
    }
}

