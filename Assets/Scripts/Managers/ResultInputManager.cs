using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ResultInputManager : MonoBehaviour
{
    [SerializeField]
    private GameManager m_gameManager;
    private InputActions m_inputActions;

    private void Awake()
    {
        // 各ボタンのイベントで呼ぶ関数を設定
        m_inputActions = new InputActions();
        m_inputActions.ResultScene.A.started += OnTitle;
        m_inputActions.ResultScene.B.started += OnGame;

        m_inputActions.Enable();
    }

    private void OnDestroy()
    {
        m_inputActions?.Dispose();
    }

    private void OnTitle(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // 説明シーンへ遷移
        StartCoroutine(m_gameManager.OnChangeScene(m_gameManager.GetTitle()));
    }

    private void OnGame(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // 説明シーンへ遷移
        StartCoroutine(m_gameManager.OnChangeScene(m_gameManager.GetGame()));
    }
}
