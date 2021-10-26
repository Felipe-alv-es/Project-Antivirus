using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
 
    public Transform player;
    private Vector3 Cam;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        Cam = new Vector3 (player.transform.position.x, player.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp (transform.position, Cam, 3*Time.deltaTime);
    }
}

