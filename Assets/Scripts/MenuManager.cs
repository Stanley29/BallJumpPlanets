using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static int score;        // The player's score.
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        score = ScoreManager.score;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "BallHit: " + score;
    }
}
