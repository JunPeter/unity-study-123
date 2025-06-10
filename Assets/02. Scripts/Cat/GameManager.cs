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

            playTimeUI.text = $"�÷��� �ð�: {timer:F1} ��";
            scoreUI.text = $"X {score}";
        }
    }
}
