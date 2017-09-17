using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelect : MonoBehaviour {
    static public int difficulty;
    public int chooseDiff = 0;

    public int SetDifficulty () {
        difficulty = chooseDiff;
        return difficulty;
    }
}
