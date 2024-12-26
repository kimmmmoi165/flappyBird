using UnityEngine;

public class PipeIncreaseScore : MonoBehaviour
{
    // Giả sử bạn muốn thêm điểm mỗi khi một sự kiện xảy ra
    private void OnTriggerEnter(Collider other)
    {
        // Thêm 10 điểm mỗi khi va chạm xảy ra (tùy theo logic game của bạn)
        ScoreManager.Instance.AddScore(1);  // Thêm 1 điểm vào điểm hiện tại
    }
}
