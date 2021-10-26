using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemSpawn : MonoBehaviour
{

    public GameObject Protagonist;
    public float timeLeft = 1f;
    public GameObject SpawnSprite;

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
            SpawnProtagonist();
        }
    }

    void SpawnProtagonist()
    {
        Protagonist.SetActive(true);
        SpawnSprite.SetActive(true);

    }
}
