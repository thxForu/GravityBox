using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class PlayerHealthBar : MonoBehaviour
    {
        [SerializeField] private Image[] heartsImages;
        [SerializeField] private Health playerHealth;
        private void Start()
        {
            GameEvents.current.onPlayerTakeDamage += UpdateHealth;
            playerHealth ??= GameObject.Find("Player").GetComponent<Health>();
        }

        private void UpdateHealth()
        {
            for (int i = 0; i < Mathf.Abs(playerHealth.GetHealthPoints()-4); i++)
            {
                Debug.Log(i);
                heartsImages[i].GetComponent<Image>().color = Color.white;
            }
        }
    }
}