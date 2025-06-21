using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class FlashText : MonoBehaviour
{
    [SerializeField] private float StartSpeed = 1.0f;
    [SerializeField] private float PushASpeed = 15.0f;
    private CanvasGroup canvasGroup;
    private float FlashSpeed;
    private float timer;

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        FlashSpeed = StartSpeed;
    }

    void Update()
    {
        //���ł��鑬�x�̏���
        timer += Time.deltaTime * FlashSpeed;

        // ���ł��鏈��
        canvasGroup.alpha = Mathf.Abs(Mathf.Sin(timer));
    }

    public void Flash()
    {
        FlashSpeed = PushASpeed;
    }
}
