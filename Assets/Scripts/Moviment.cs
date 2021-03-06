using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{

    public float speed;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        Move();
        
    }

        void Move()
    {
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += Movement * Time.deltaTime * speed;

        if(Input.GetAxis("Horizontal") > 0f)
        {
            anim.SetBool("Walk", true); // Animação
            transform.eulerAngles = new Vector3 (0f,0f,0f);
        }

        if(Input.GetAxis("Horizontal") < 0f)
        {
            anim.SetBool("Walk", true); // Animação
            transform.eulerAngles = new Vector3 (0f,180f,0f);
        }

        if(Input.GetAxis("Horizontal") == 0f)
        {
            anim.SetBool("Walk", false); // Animação
        }

    }
}
