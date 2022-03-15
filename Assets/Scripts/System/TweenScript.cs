using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class TweenScript : MonoBehaviour
{
    #region Private Variables

    Vector2 startPos = Vector2.zero;
    Quaternion startRot = new Quaternion(0,0,0,0);
    Vector3 startScale = Vector2.zero;

    [Header("Tween Values")]
    [Space(10)]
    [Tooltip("The position for the object ot tween to")]
    [SerializeField] Vector3 tweenLocation;
    [Tooltip("The rotation for the object to tween to")]
    [SerializeField] Quaternion tweenRotation;
    [Tooltip("The scale for the object to tween to")]
    [SerializeField] Vector2 tweenScaleMarker;

    [Header("Tween Times")]
    [Space(10)]
    [Tooltip("The time it takes to complete the move section of the tween")]
    [SerializeField] float moveTweenTime = 0f;
    [Tooltip("The time it takes to complete the rotation section of the tween")]
    [SerializeField] float rotationTweenTime = 0f;
    [Tooltip("The time it takes to omplete the scale section of the tween")]
    [SerializeField] float scaleTweenTime = 0f;

    [Space(10)]
    [Tooltip("Callbacks to be performed when a tween is completed")]
    [SerializeField] UnityEvent OnTweenComplete;

    [Space(10)]
    [Tooltip("Callbacks to be performed when a tween is returned to starting positions")]
    [SerializeField] UnityEvent OnTweenReturn;

    #endregion


    // Start is called before the first frame update
    void Awake()
    {
        startPos = transform.position;
        startRot = transform.localRotation;
        startScale = transform.localScale;
    }

    public void ReturnTween()
    {
        Sequence mySequence = DOTween.Sequence();

        mySequence.Join(transform.DOMove(startPos, moveTweenTime))
            .Join(transform.DORotateQuaternion(startRot, rotationTweenTime))
            .Join(transform.DOScale(startScale, scaleTweenTime))
            .OnComplete(() => OnTweenReturn.Invoke());
    }

    public void BeginTween()
    {
        Sequence mySequence = DOTween.Sequence();

        mySequence.Join(transform.DOMove(tweenLocation, moveTweenTime))
            .Join(transform.DORotateQuaternion(tweenRotation, rotationTweenTime))
            .Join(transform.DOScale(tweenScaleMarker, scaleTweenTime))
            .OnComplete(() => OnTweenComplete.Invoke());
        
    }
}
