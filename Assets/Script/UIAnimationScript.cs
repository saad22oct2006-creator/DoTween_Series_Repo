using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIAnimationScript : MonoBehaviour
{
    public Button playButton;
    public Button settingButton;
    public Button exitButton;

    void Start()
    {
        playButton.transform.DOScale(new Vector3(2.7f,5.4f,0.8f),0.7f)
            .SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        
        exitButton.transform.DOScale(new Vector3(2.7f,5.4f,0.8f),0.7f)
            .SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        
        settingButton.transform.DOScale(new Vector3(2.7f,5.4f,0.8f),0.7f)
            .SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        
        playButton.onClick.AddListener(PlayButtonAnim);
        exitButton.onClick.AddListener(ExitButtonAnim);
        settingButton.onClick.AddListener(SettingButtonAnim);   
    }


    public void PlayButtonAnim()
    {
        playButton.transform.DOScale(new Vector3(4f,6.5f,1.5f),0.7f).SetEase(Ease.InBounce);
    }

    public void ExitButtonAnim()
    {
        exitButton.transform.DORotate(new Vector3(0,0,60),0.5f)
            .SetEase(Ease.InBounce).OnComplete(() => exitButton.transform.DORotate(new Vector3(0f, 0f, 0f), 0.5f));
    }

    public void SettingButtonAnim()
    {
        settingButton.transform.DOPunchScale(Vector3.one, 0.5f, 10, 10)
            .SetEase(Ease.OutElastic);
    }
    
    
    
    
    
    
}
