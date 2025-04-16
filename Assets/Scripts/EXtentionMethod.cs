using PrimeTween;
using UnityEngine;

public static class EXtentionMethod
{
    public static void Fade(this CanvasGroup canvasGroup, bool isShow)
    {
        float targetAlpha = isShow ? 1f:0f;

        if(Mathf.Approximately(canvasGroup.alpha, targetAlpha))
        {
            canvasGroup.SetCanvasGroupInteraction(isShow);
            return;
        }
        canvasGroup.SetCanvasGroupInteraction(isShow);
        Tween.Alpha(canvasGroup, targetAlpha, 0.5f);
    }
    public static void SetCanvasGroupInteraction(this CanvasGroup canvasGroup , bool isEnable)
    {
        canvasGroup.blocksRaycasts = isEnable;
        canvasGroup.interactable = isEnable;
    }
}
