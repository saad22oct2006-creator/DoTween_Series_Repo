using UnityEngine;
using DG.Tweening;
public class DoTweenAnimation : MonoBehaviour
{
    public Transform cube1;
    public Transform cube2;
    public Transform cube3;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //cube1.DOMoveX(10f, 2f).SetDelay(0f).SetEase(Ease.OutQuad);
        //cube2.DOMoveX(10f, 2f).SetDelay(0.2f).SetEase(Ease.OutQuad);
        //cube3.DOMoveX(10f, 2f).SetDelay(0.4f).SetEase(Ease.OutQuad);

        cube1.DOScale(new Vector3(5f, 5f, 5f), 0.8f).SetDelay(0.3f).SetEase(Ease.InElastic);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
