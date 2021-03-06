﻿using UnityEngine;
using UnityEngine.UI;

public class DisplayHealth : MonoBehaviour
{
    Text healthText;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {

        healthText.text = player.GetHealth().ToString();
    }
}