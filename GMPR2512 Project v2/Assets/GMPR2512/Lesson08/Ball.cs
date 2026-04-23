using UnityEngine;
using GMPR2512.Lesson08;

public class Ball : MonoBehaviour
{
    [SerializeField] private GameState _gameState;

    void OnCollisionEnter2D(Collision2D collision)
    {
        _gameState.ScoreLevel01++;
    }
}
