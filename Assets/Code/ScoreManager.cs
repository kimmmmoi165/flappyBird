using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Singleton để đảm bảo chỉ có một instance của ScoreManager
    public static ScoreManager Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;

    private int _score;

    // Chỉ có một phương thức Awake duy nhất
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;  // Đảm bảo chỉ có một instance duy nhất
            DontDestroyOnLoad(gameObject);  // Giữ ScoreManager qua các scene nếu cần
        }
        else
        {
            Destroy(gameObject); // Hủy đối tượng này nếu đã có instance khác
        }
    }

    // Chỉ có một phương thức Start duy nhất
    private void Start()
    {
        _score = 0;
        UpdateScoreText();
        _highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Phương thức để cập nhật điểm
    private void UpdateScoreText()
    {
        _currentScoreText.text = _score.ToString();
    }

    // Thêm điểm và cập nhật điểm trên UI
    public void AddScore(int amount)
    {
        _score += amount;
        UpdateScoreText();
        UpdateHighScore();
    }

    // Lấy điểm hiện tại
    public int Score => _score;

    // Kiểm tra và cập nhật điểm cao
    private void UpdateHighScore()
    {
        int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);

        if (_score > currentHighScore)
        {
            PlayerPrefs.SetInt("HighScore", _score);  // Cập nhật điểm cao mới
            _highScoreText.text = _score.ToString();  // Cập nhật UI điểm cao
        }
    }
}
