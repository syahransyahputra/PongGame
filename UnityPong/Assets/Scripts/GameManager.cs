using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int ScorePlayer1, ScorePlayer2;
    public ScoreText scoreTextLeft, scoreTextRight;

    public void OnScoreZoneReached(int id)
    {
        if(id == 1)
        {
            ScorePlayer1++;
        }
        if(id == 2)
        {
            ScorePlayer2++;
        }

        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreTextLeft.SetScore(ScorePlayer1);
        scoreTextRight.SetScore(ScorePlayer2);
    }
}
