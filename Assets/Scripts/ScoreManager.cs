using System;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText; // Reference to the TextMeshProUGUI component that displays the score

    private int _score = 0; // Variable to keep track of the player's score

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreUI(); // Update the score UI to display the initial score
    }

    public void IncrementScore()
    {
        _score++; // Increment the score by 1
        UpdateScoreUI(); // Update the score UI to reflect the new score
    }

    private void UpdateScoreUI()
    {
        _scoreText.text = _score.ToString(); // Update the text of the score UI to display the current score
    }
}
