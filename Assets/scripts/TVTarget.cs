using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVTarget : MonoBehaviour
{
    public Score scoreManager;
    public GameObject screen = null;

    private bool hit = false;

    //this method is called whenever a collision is detected
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "bullet" && !hit)
        {
            hit = true;
            screen.SetActive(false);
            scoreManager.AddPoint();
        }
    }
}