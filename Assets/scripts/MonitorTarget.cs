using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorTarget : MonoBehaviour
{
    public Score scoreManager;
    public GameObject replacement = null;

    private bool hit = false;

    Quaternion new_rotation = Quaternion.Euler(0, 180, 0);

    //this method is called whenever a collision is detected
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet" && !hit)
        {
            hit = true;
            scoreManager.AddPoint();
            Instantiate(replacement, transform.position, new_rotation);
            Destroy(gameObject);
        }
    }
}
