using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int Score;
    public int ScoreIncrease;
    public int ScoreDecrease;

    // Start is called before the first frame update
    void Start()
    {
        Score = PlayerPrefs.GetInt("TheScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
