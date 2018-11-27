using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    public static int score = 0;
    public int endGame;
	
	
	// Update is called once per frame
	void Start ()
    {
        int currentHighScore = PlayerPrefs.GetInt("HighScore");
        GetComponent<Text>().text = "FINAL SCORE: " + currentHighScore.ToString();
	}
}
