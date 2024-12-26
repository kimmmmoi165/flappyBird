using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BirdController : MonoBehaviour
{
    public float flyForce = 10f;    // Lực bay của chim
    public float gravityScale = 1f; // Tỷ lệ trọng lực cho chim

    private Rigidbody2D rb;         // Biến để truy cập vào Rigidbody2D

    void Start()
    {
        // Lấy Rigidbody2D của đối tượng chim
        rb = GetComponent<Rigidbody2D>();

        // Đặt tỷ lệ trọng lực cho chim để có cảm giác trọng lực tự nhiên
        rb.gravityScale = gravityScale;
    }

    void Update()
    {
        // Kiểm tra nếu người chơi nhấn phím (ví dụ: phím Space)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Áp dụng một lực lên chim để làm nó bay lên
            rb.linearVelocity = Vector2.up * flyForce;
        }
    }
}
