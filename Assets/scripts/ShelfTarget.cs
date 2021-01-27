using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfTarget : MonoBehaviour
{
    public Score scoreManager;
    public GameObject newShelf = null;

    private bool hit = false;

    //this method is called whenever a collision is detected
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet" && !hit)
        {
            hit = true;
            scoreManager.AddPoint();
            Instantiate(newShelf, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
