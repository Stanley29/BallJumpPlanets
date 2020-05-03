using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    GameObject player;
    public int scoreCoinValue = 1;
    //in the editor this is what you would set as the object you wan't to change
    public GameObject Object;
    public Material[] materials;

    void Awake()
    {
        // Setting up the references.
       player = GameObject.FindGameObjectWithTag("Player");
       
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        // If the entering collider is the player...
        if (other.gameObject == player)
        {
            // Increase the score by score value.
            ScoreManager.score += scoreCoinValue;
            Object.GetComponent<SpriteRenderer>().material = materials[UnityEngine.Random.Range(0, materials.Length)];
        }
    }
}
