using UnityEngine;
using DG.Tweening;
public class DoTweenAnimation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.DOMoveX(5f, 2f).OnComplete(() =>
        {
            transform.DOMoveY(50f, 1f);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
