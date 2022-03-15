﻿using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public GameManager gm;
    public Transform player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        if(gm.gameHasEnded == true)
        {
            scoreText.text = "SOS MALARDO";
        }
    }
}
