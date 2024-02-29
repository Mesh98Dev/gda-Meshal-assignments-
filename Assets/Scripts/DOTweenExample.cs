using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DOTweenExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /* transform.DOMove(new Vector3(10,15,10),4)
        .SetLoops(-1)
        .SetEase(Ease.OutCubic);*/
        var seq = DOTween.Sequence();
        seq.Append(transform.DOMove(new Vector3(10,15,10),4));
        seq.Join(transform.DORotate(new Vector3(180,0,0),4));
    }

    // Update is called once per frame
    void AfterAnimation()
    {
        Debug.Log("Animation  Complete");
    }
}
