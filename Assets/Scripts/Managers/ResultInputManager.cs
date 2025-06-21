using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class ResultInputManager : MonoBehaviour
{
    private GameManager m_gameManager;
    private InputActions m_inputActions;

    [SerializeField]
    private Score m_score;

    private void Awake()
    {
        // �e�{�^���̃C�x���g�ŌĂԊ֐���ݒ�
        m_inputActions = new InputActions();
        m_inputActions.ResultScene.A.started += OnTitle;
        m_inputActions.ResultScene.B.started += OnGame;

        var gameManagerObj = GameObject.Find("GameManager");
        m_gameManager = gameManagerObj.GetComponent<GameManager>();

        m_score.ResultScore(m_gameManager.GetScore());

        m_inputActions.Enable();
    }

    private void OnDestroy()
    {
        m_inputActions?.Dispose();
    }

    private void OnTitle(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // �����V�[���֑J��
        StartCoroutine(m_gameManager.OnChangeScene(m_gameManager.GetTitle()));
    }

    private void OnGame(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // �����V�[���֑J��
        StartCoroutine(m_gameManager.OnChangeScene(m_gameManager.GetGame()));
    }
}
