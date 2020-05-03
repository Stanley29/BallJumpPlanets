using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoMouse : MonoBehaviour
{
    public float moveSpeed = 20.0f;  // Units per second

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var pos = Input.mousePosition;
            pos.z = transform.position.z - Camera.main.transform.position.z;
            pos = Camera.main.ScreenToWorldPoint(pos);
            transform.position = Vector3.MoveTowards(transform.position, pos, moveSpeed * Time.deltaTime);
        }
    }
}
