﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour {
    static public int score = 0;

    // Update is called once per frame
    void Update() {
        Text gt = this.GetComponent<Text>();
        gt.text = "Game Over \n \n Final Score: " + score;
    }
}
