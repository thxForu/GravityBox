using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private Health healthComponent;
        [SerializeField] private Image foreground;
        [SerializeField] private Canvas rootCanvas;

        private void Update()
        {
            if (Mathf.Approximately(healthComponent.GetFraction(),1))
            {
                rootCanvas.enabled = false;
                return;
            }

            rootCanvas.enabled = true;
            foreground.fillAmount = healthComponent.GetFraction();
        }
    }
}
