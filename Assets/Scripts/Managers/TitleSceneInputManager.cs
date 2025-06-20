using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TitleSceneInputManager : MonoBehaviour
{
    [SerializeField] private GameManager m_gameManager;
    private InputActions m_inputActions;
    private GameManager.S_SceneNames m_sceneNames;

    private void Awake()
    {
        // 各ボタンのイベントで呼ぶ関数を設定
        m_inputActions = new InputActions();
        m_inputActions.TitleScene.A.started += OnGameStart;

        m_inputActions.Enable();
    }

    private void OnDestroy()
    {
        m_inputActions?.Dispose();
    }

    private void OnGameStart(InputAction.CallbackContext context)
    {
        // 説明シーンへ遷移
        StartCoroutine(m_gameManager.OnChangeScene(m_sceneNames.GetExplanation()));
    }
}
