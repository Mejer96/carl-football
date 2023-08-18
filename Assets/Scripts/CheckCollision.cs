using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckCollision : MonoBehaviour
{
    public ScoreLogic _score;
    public GameObject _player;
    Vector3 _ballSpawnPosition;
    Vector3 _playerSpawnPosition;

    private void Start()
    {
        _ballSpawnPosition = transform.position;
        _playerSpawnPosition = _player.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sideline")
        {
            transform.position = _ballSpawnPosition;
            _player.transform.position = _playerSpawnPosition;
        }

        if (collision.gameObject.tag == "GoalLine")
        {
            _score.AddScore();
            transform.position = _ballSpawnPosition;
            _player.transform.position = _playerSpawnPosition;
        }
    }
}
