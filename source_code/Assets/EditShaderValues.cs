using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditShaderValues : MonoBehaviour
{
    public void setHeight(float height) {
        gameObject.GetComponent<Renderer>().material.SetFloat("Vector1_e56c1fbb759144b2994d5cace07029ba", height);
    }

    public void setScrollSpeed(float scrollSpeed) {
        gameObject.GetComponent<Renderer>().material.SetFloat("Vector1_ca59a8414a6e4796ab5bf41b257bab24", scrollSpeed);
    }


    public void setNoise(float noise) {
        gameObject.GetComponent<Renderer>().material.SetFloat("Vector1_485a2d7289de49948b5fe821bfbf4fe8", noise);
    }

}
