using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
	private GameObject gameOverText;
	private bool isGameOver = false;

	private GameObject scoreText;
	private int score = 0;

    // Use this for initialization
    void Start()
    {
		this.gameOverText = GameObject.Find("GameOver");
		this.scoreText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
		if (this.isGameOver)
		{
			if (Input.GetMouseButtonDown(0))
			{
				SceneManager.LoadScene("MainScene");
			}
		}
    }

	public void GameOver()
	{
		this.gameOverText.GetComponent<Text>().text = "GameOver";
		this.isGameOver = true;
	}

	public void Score()
	{
		this.score += 10;
		this.scoreText.GetComponent<Text>().text = "Score:" + this.score + "pt";
	}
}
