using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PipeController : MonoBehaviour
{
    [SerializeField] private float _speed = 0.65f;
    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Đảm bảo nhân vật có tag là "Player"
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddScore(1); // Tăng điểm khi đi qua
            }
        }
    }
}