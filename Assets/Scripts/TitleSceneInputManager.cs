using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TitleSceneInputManager : MonoBehaviour
{
    [SerializeField] private GameManager m_gameManager;
    private InputActions m_inputActions;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        // �e�{�^���̃C�x���g�ŌĂԊ֐���ݒ�
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
        // �����V�[���֑J��
        m_gameManager.OnChangeScene("ExplanationScene");
    }
}
