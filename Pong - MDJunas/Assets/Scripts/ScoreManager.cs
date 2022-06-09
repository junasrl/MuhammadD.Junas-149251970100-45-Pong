using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int skorKanan;
    public int skorKiri;
    public int maxScore;

    public BallControl ball;

    public void addRightScore(int increment)
    {
        ball.ResetBall();
        skorKanan += increment;
        Debug.Log("Gol kanan");
         scoreChecker(skorKanan);
    }

    public void addLeftScore(int increment)
    {
        ball.ResetBall();
        skorKiri += increment;
        Debug.Log("Gol kiri");
        scoreChecker(skorKiri);
    }

    public void scoreChecker(int Score)
    {
        if(Score >= maxScore)
        {
        Debug.Log("Game selesai");
        gameOver();
        }
    }
    public void gameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
