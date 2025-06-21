using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TitleSceneInputManager : MonoBehaviour
{
    private GameManager m_gameManager;
    private InputActions m_inputActions;

    [SerializeField]
    private FlashText m_flashText;

    private void Awake()
    {
        // 各ボタンのイベントで呼ぶ関数を設定
        m_inputActions = new InputActions();
        m_inputActions.TitleScene.A.started += OnGameStart;

        var gameManagerObj = GameObject.Find("GameManager");
        m_gameManager = gameManagerObj.GetComponent<GameManager>();

        m_inputActions.Enable();
    }

    private void OnDestroy()
    {
        m_inputActions?.Dispose();
    }

    private void OnGameStart(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // 説明シーンへ遷移
        StartCoroutine(m_gameManager.OnChangeScene(m_gameManager.GetGame()));
        m_flashText.Flash();
    }
}
