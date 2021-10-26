using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptJump : MonoBehaviour
{

    private Rigidbody2D rig;
    public float JumpForce;
    private Animator anim;
    public bool AnimDoubleJump;
    public bool isJumping;
    public bool doubleJump;

    // Start is called before the first frame update
    void Start()
    {

        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Jump();

    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {

            if(Input.GetButtonDown("Jump"))
            {
                anim.SetBool("Jump", true);
            }

            if(Input.GetButtonDown("Jump") && AnimDoubleJump == true)
            {
                anim.SetBool("AnimDoubleJump", true);
            }

            if(!isJumping)
            {
                rig.AddForce(new Vector3(0f, JumpForce, 0f), ForceMode2D.Impulse);
                doubleJump = true;  
                AnimDoubleJump = true;

                                   
            }
            else 
            {
                if(doubleJump)
                {
                    rig.AddForce(new Vector3(0f, JumpForce, 0f), ForceMode2D.Impulse);
                    doubleJump = false;  
                }
                
            }
            
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            isJumping = false;
            anim.SetBool("Jump", false);
            AnimDoubleJump = false;
            anim.SetBool("AnimDoubleJump", false);
        }
             
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            isJumping = true;
          //  anim.SetBool("Jump", true);
        }
    }
}
