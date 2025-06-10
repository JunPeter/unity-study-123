using TMPro;
using UnityEngine;

namespace Cat
{
    public class GameManager : MonoBehaviour
    {
        public TextMeshProUGUI playTimeUI;
        public TextMeshProUGUI scoreUI;

        private float timer;
        public static int score;

        private void Update()
        {
            timer += Time.deltaTime;

            playTimeUI.text = $"플레이 시간: {timer:F1} 초";
            scoreUI.text = $"X {score}";
        }
    }
}
