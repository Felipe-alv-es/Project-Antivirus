using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparencyWhiteScreen : MonoBehaviour
{

    public KeyCode IncreaseAlpha;
    public KeyCode DecreaseAlpha;
    public float AlphaLevel = 5f;
    public float timeLeft = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0f)
        {
            AlphaLevel -= .008f;
        }

        GetComponent<SpriteRenderer>().color = new Color (1,1,1,AlphaLevel);
    }
}
