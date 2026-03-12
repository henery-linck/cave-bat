using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText; // Reference to the TextMeshProUGUI component that displays the score

    private int _score = 0; // Variable to keep track of the player's score
    private Vector3 _originalScale; // Original scale of the score text for pulsing effect

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _originalScale = _scoreText.transform.localScale; // Store the original scale of the score text
        UpdateScoreUI(); // Update the score UI to display the initial score
    }

    public void IncrementScore()
    {
        _score++; // Increment the score by 1
        UpdateScoreUI(); // Update the score UI to reflect the new score

        StartCoroutine(PulseScoreText());
    }

    private void UpdateScoreUI()
    {
        _scoreText.text = _score.ToString(); // Update the text of the score UI to display the current score
    }

    private IEnumerator PulseScoreText()
    {
        _scoreText.transform.localScale = _originalScale * 1.3f;

        yield return new WaitForSeconds(0.1f);

        _scoreText.transform.localScale = _originalScale;
    }
}
