using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private PlayerColor PC;
    private SpriteRenderer SR;

    // Start is called before the first frame update
    void Start()
    {
        PC = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerColor>();
        SR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PC.PlayerNum == 0)
        {
            SR.color = Color.red;
        }
        else if (PC.PlayerNum == 1)
        {
            SR.color = Color.blue;
        }
        else if (PC.PlayerNum == 2)
        {
            SR.color = Color.yellow;
        }
        else if (PC.PlayerNum == 3)
        {
            SR.color = Color.green;
        }
    }
}
