using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {
    public int score = 0;

    void OnGUI()
    {
        GUI.Label(new Rect(10,10,100,30), "SCORE : " + score);
    }

    void Update()
    {
        score++;
    }
}
