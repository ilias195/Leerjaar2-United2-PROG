using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
   [SerializeField] ScoreManager scoreManager;
    [SerializeField] TextMeshProUGUI scoreText;
    private void Start()
    {
        scoreText.text = "Score: 0";
    }

    private void OnEnable()
    {
        Collection.Oncollected += UpdateText;
    }

    private void OnDisable()
    {
        Collection.Oncollected -= UpdateText;
    }

    private void UpdateText(int updateScore)
    {
        scoreText.text = "Score: " + scoreManager.Score;
    }


}
