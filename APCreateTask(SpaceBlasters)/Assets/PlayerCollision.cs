using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerController PC;
    private ScoreKeeper SK;

    // Start is called before the first frame update
    void Start()
    {
        PC = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        SK = GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Green" && PC.IsShooting)
        {
            SK.Score = SK.Score + SK.ScoreIncrease;
        }

        if (collision.gameObject.tag == "Red" && PC.IsShooting)
        {
            SK.Score = SK.Score - SK.ScoreDecrease;
        }
    }
}
