using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    public Color color1 = Color.blue;//light blue
    public Color color2 = Color.grey;//gray
    public Color color3 = Color.red;//orange

    // Start is called before the first frame update
    void Start()
    {
        
        switch (ButtonScript.Planet)
        {
            case 1:
                Camera.main.backgroundColor = color1; 
                Physics2D.gravity = new Vector2(0, -9.8f);
                break;

            case 2:
                Camera.main.backgroundColor = color2;
                Physics2D.gravity = new Vector2(0, -1.6f);
                break;

            case 3:
                Camera.main.backgroundColor = color3;
                Physics2D.gravity = new Vector2(0, -24.5f);
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene(0);
        }
    }
}
