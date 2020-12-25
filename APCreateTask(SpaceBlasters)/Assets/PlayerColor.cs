using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerColor : MonoBehaviour
{
    private PlayerInput PI;
    public float PlayerNum;

    // Start is called before the first frame update
    void Start()
    {
        PI = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PI.playerIndex == 0)
        {
            PlayerNum = 0;
        }
        else if (PI.playerIndex == 1)
        {
            PlayerNum = 1;
        }
        else if (PI.playerIndex == 2)
        {
            PlayerNum = 2;
        }
        else if (PI.playerIndex == 3)
        {
            PlayerNum = 3;
        }
    }
}
