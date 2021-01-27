using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordPlayerTarget : MonoBehaviour
{
    public Score scoreManager;
    public GameObject music = null;
    public RecordPlayer player = null;

    private bool hit = false;

    //this method is called whenever a collision is detected
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet" && !hit)
        {
            hit = true;
            scoreManager.AddPoint();
            music.SetActive(false);
            player.recordPlayerActive = false;
        }
    }
}
