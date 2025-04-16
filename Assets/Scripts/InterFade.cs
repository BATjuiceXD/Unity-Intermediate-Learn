using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class InterFade : MonoBehaviour
{
   [SerializeField] private CanvasGroup _canvasGroup;
   [SerializeField] private float _fadespeed =1f;

   private bool _isShown;

   IEnumerator Fade()
   {
    if(_isShown)
    {
        while(_canvasGroup.alpha <1f)
        {
            _canvasGroup.alpha += Time.deltaTime * _fadespeed; 
        }
    }else
    {
        while(_canvasGroup.alpha >0f)
        {
            _canvasGroup.alpha -= Time.deltaTime * _fadespeed; 
        }
    }
    yield return new WaitForSeconds(0.5f);
    Debug.Log("Fade");
   }
   [ContextMenu("Toggle Ui")]
   public void ToggleUI()
   {
    _isShown = !_isShown;
    _canvasGroup.Fade(_isShown);
    // StartCoroutine(Fade());
   }
}
