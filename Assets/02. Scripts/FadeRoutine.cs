using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeRoutine : MonoBehaviour
{
    public Image fadePanel;


    private void Start()
    {
        StartCoroutine(FadeRoutineA(3, true));
        //StartCoroutine(FadeRoutineA(3, false));
    }
    IEnumerator FadeRoutineA(float fadeTime, bool isFadeIn)
    {
        float timer = 0f;
        float percent = 0f;
        float value = 0f;
        while (percent <= 1f)
        {
            timer += Time.deltaTime;
            percent = timer / fadeTime;
            value = isFadeIn ? percent : 1 - percent;

            fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, 1 - percent);
            yield return null;
        }
    }
}
