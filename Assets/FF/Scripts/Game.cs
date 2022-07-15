using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private PipeGenerator _pipeGenerator;
    [SerializeField] private StartScreen _startScreen;
    [SerializeField] private RestartScreen _restartScreen;

    private void OnEnable()
    {
        _startScreen.PlayButtonClick += OnPlayButtonClick;
        _restartScreen.RestartButtonClick += OnRestartButtonClick;
        _bird.GameOver += OnGameOver;
    }
    private void OnDisable()
    {
        _startScreen.PlayButtonClick -= OnPlayButtonClick;
        _restartScreen.RestartButtonClick -= OnRestartButtonClick;
        _bird.GameOver -= OnGameOver;

    }
    private void Start()
    {
        _restartScreen.Close();
        Time.timeScale = 0;
        _startScreen.Open();
    }
    private void OnPlayButtonClick()
    {
        _startScreen.Close();
        StartGame();
    }
    private void OnRestartButtonClick()
    {
        _restartScreen.Close();
        _pipeGenerator.ResetPool();
        StartGame();
    }

    private void StartGame()
    {
        Time.timeScale = 1;
        _bird.ResetPlayer();
    }
    public void OnGameOver()
    {
        _restartScreen.Open();
        Time.timeScale = 0;
    }
}
