using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 0.65f;

    private void Update()
    {
        // Di chuyển ống sang trái
        transform.position += Vector3.left * _speed * Time.deltaTime;

        // Xóa ống nếu nó ra khỏi màn hình
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}

