using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour {

    public TextMeshProUGUI scoreText;
    int score;

    void Start () {
        score = 0;
    }
    
    public void addScore(int n){
        score += n;
        scoreText.text = "Score : " + score;
    }
}
