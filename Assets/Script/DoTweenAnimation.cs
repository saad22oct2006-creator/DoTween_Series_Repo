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

        Sequence cube1Seq = DOTween.Sequence();
        Sequence cube2Seq = DOTween.Sequence();

        //cube1.DOMoveX(10f, 2f).SetDelay(0f).SetEase(Ease.OutQuad);
        //cube2.DOMoveX(10f, 2f).SetDelay(0.2f).SetEase(Ease.OutQuad);
        //cube3.DOMoveX(10f, 2f).SetDelay(0.4f).SetEase(Ease.OutQuad);

        //cube1.DOScale(new Vector3(5f, 5f, 5f), 0.8f).SetDelay(0.3f).SetEase(Ease.InElastic);

        
        cube1Seq.Append(cube1.DOMoveZ(10,0.3f).SetEase(Ease.Flash)).SetDelay(1f)
            .Append(cube1.DOScale(new Vector3(5f,5f,5f),0.3f).SetEase(Ease.InBounce));

        cube2Seq.PrependInterval(2f);
        cube2Seq.Append(cube2.DORotate(new Vector3(0f,180f,0f),0.3f).SetEase(Ease.InFlash)).SetDelay(1f)
            .Append(cube2.DOMoveZ(20f,0.3f).SetEase(Ease.InBounce));



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
