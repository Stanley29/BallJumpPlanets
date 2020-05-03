using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static int score;        // The player's score.
    public Text text;                      // Reference to the Text component.


    void Awake()
    {
        
        // Reset the score.
        //score = 0;
        score = MenuManager.score;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Score: " + score;
    }
}
