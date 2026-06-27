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

        //Sequence cube1Seq = DOTween.Sequence();

        //cube1.DOMoveX(10f, 2f).SetDelay(0f).SetEase(Ease.OutQuad);
        //cube2.DOMoveX(10f, 2f).SetDelay(0.2f).SetEase(Ease.OutQuad);
        //cube3.DOMoveX(10f, 2f).SetDelay(0.4f).SetEase(Ease.OutQuad);

        //cube1.DOScale(new Vector3(5f, 5f, 5f), 0.8f).SetDelay(0.3f).SetEase(Ease.InElastic);


        /*cube1Seq.Append(cube1.DOMoveZ(10, 0.3f).SetEase(Ease.Flash))
            .Join(cube1.DORotate(new Vector3(0, 360, 0), 0.3f).SetEase(Ease.Flash))
            .Join(cube1.GetComponent<Renderer>().material.DOColor(Color.magenta, 1f).SetEase(Ease.Flash));*/
        
        cube1.DOMoveY(20f, 1f).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
        cube2.DORotate(new Vector3(0f,360f,0f),1f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
        cube3.DOScale(new Vector3(0.5f,0.5f,0.5f),1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
