using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BirdMove))]
public class Bird : MonoBehaviour
{
    private BirdMove _move;
    private int _score;

    public event UnityAction GameOver;
    public event UnityAction<int> ScoreChanged;


    private void Start()
    {
        _move = GetComponent<BirdMove>();

    }

    public void IncreaseScore()
    {
        _score++;
        ScoreChanged?.Invoke(_score);
    }

    public void ResetPlayer()
    {
        _score = 0;
        ScoreChanged?.Invoke(_score);

        _move.ResetBird();

    }

    public void Die()
    {
        GameOver?.Invoke();
    }
}
