using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
     public float horizontalSpeed;
 
    public float verticalSpeed;
 
    public float amplitude;
 
    private Vector3 originalPos;
    private Vector3 tempPosition;
 
 
    // Start is called before the first frame update
    void Start()
    {
        tempPosition = originalPos = transform.position;
 
    }
 
    // Update is called once per frame
    void FixedUpdate()
    {
        tempPosition = originalPos;
        tempPosition.x += horizontalSpeed * Time.fixedDeltaTime;
        tempPosition.y += Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude;
        transform.position = tempPosition;
 
    }
}
