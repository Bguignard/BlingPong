using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public static int player1Score = 0;
    public static int player2Score = 0;
    public Text scoreText;
    static Score instance;
    static float m_timer = 0.0f;
    static GameObject imagePanel;
    private static bool isTimeOk = false;


    public static void addPlayer1Score(int number)
    {
        player1Score += number;
        if (instance.scoreText != null)
            instance.scoreText.text = string.Format("Player 1 [{0} - {1}] Player 2", player1Score, player2Score);

        if (imagePanel != null) {
            imagePanel.SetActive(true);
            m_timer = 0.0f;
            isTimeOk = true;
        }
    }

    public static void addPlayer2Score(int number)
    {
        player2Score += number;
        if (instance.scoreText != null)
            instance.scoreText.text = string.Format("Player 1 [{0} - {1}] Player 2", player1Score, player2Score);

        if (imagePanel != null)
        {
            imagePanel.SetActive(true);
            m_timer = 0.0f;
            isTimeOk = true;
        }
    }


    // Use this for initialization
    void Start () {
        instance = this;
        //CnvScore.TxtScore.text = "0";
        if (scoreText != null)
            scoreText.text = string.Format("Player 1 [{0} - {1}] Player 2", player1Score, player2Score);

        imagePanel = GameObject.Find("ImagePanel");
        if (imagePanel != null)
        {
            imagePanel.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (isTimeOk)
        {
            m_timer += Time.deltaTime;
            if (m_timer > 2.0f && isTimeOk)
            {
                imagePanel.SetActive(false);
                isTimeOk = false;
            }
        }

    }
}
