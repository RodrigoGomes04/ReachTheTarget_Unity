using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private TMP_Text pointsText;
    public static ScoreManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        pointsText.text = "SCORE: " + score;
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        pointsText.text = "SCORE: " + score;
    }
}
