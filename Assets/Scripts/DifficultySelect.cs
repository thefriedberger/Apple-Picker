using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelect : MonoBehaviour {
    static public int difficulty;    

    public void FindDifficulty (int i) {
        difficulty = i;
        SetDifficulty(difficulty);
    }

    public int SetDifficulty (int i) {
        return i;
    }
}
