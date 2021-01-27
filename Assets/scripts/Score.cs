using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int maxScore = 5;

    public Animator door = null;
    public GameObject portal = null;

    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    //we will call this method from our target script
    // whenever the player collides or shoots a target a point will be added
    public void AddPoint()
    {
        score++;

        if (score != maxScore)
            scoreText.text = "Score: " + score;
        else
        {
            scoreText.text = "Go to door!";
            door.Play("DoorOpen");
            portal.SetActive(true);
        }
            
    }
}