using UnityEngine;
using UnityEngine.SceneManagement; // Thư viện để restart scene
using System.Collections;
using System.Collections.Generic;
public class BirdCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Kiểm tra nếu va chạm với cột
        if (collision.gameObject.CompareTag("Pipe"))
        {
            RestartGame(); // Gọi hàm restart game
        }
    }

    void RestartGame()
    {
        // Restart lại scene hiện tại
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
