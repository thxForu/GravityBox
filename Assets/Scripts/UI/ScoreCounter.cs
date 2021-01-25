using TMPro;
using UnityEngine;

namespace UI
{
    public class ScoreCounter : MonoBehaviour
    {
        [SerializeField] private int score;
        private TextMeshProUGUI scoreText;

        void Start()
        {
            GameEvents.current.onEnemyDie += UpdateScore;
            scoreText = GetComponent<TextMeshProUGUI>();
        }

        private void UpdateScore()
        {
            score += 200;
            scoreText.text = score.ToString();
        }
    
    }
}
