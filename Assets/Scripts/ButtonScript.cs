using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public static int Planet;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void EarthButton()
    {
        Planet = 1;
        SceneManager.LoadScene(01);
    }

    public void MoonButton()
    {
        Planet = 2;
        SceneManager.LoadScene(01);
    }

    public void JupiterButton()
    {
        Planet = 3;
        SceneManager.LoadScene(01);
    }
}
