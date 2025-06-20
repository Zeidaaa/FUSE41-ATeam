using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameSceneInputManager : MonoBehaviour
{
    [SerializeField]
    private GameManager m_gameManager;
    private InputActions m_inputActions;

    private void Awake()
    {
        // �e�{�^���̃C�x���g�ŌĂԊ֐���ݒ�
        m_inputActions = new InputActions();
        m_inputActions.GameScene.Up.started    += OnEnterUp;
        m_inputActions.GameScene.Down.started  += OnEnterDown;
        m_inputActions.GameScene.Right.started += OnEnterRight;
        m_inputActions.GameScene.Left.started  += OnEnterLeft;
        m_inputActions.GameScene.A.started     += OnEnterA;
        m_inputActions.GameScene.A.canceled    += OnExitA;

        m_inputActions.Enable();
    }

    private void OnDestroy()
    {
        m_inputActions?.Dispose();
    }
    
    private void OnEnterUp(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // �k������
        // ���܂���]
        // ���܂̌�����Ԃ�k��
        Debug.Log($"��");
    }

    private void OnEnterDown(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // �������
        // ���܂���]
        // ���܂̌�����Ԃ���
        Debug.Log($"��");
    }

    private void OnEnterRight(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // �E������
        // ���܂̌�����Ԃ𓌂�
        Debug.Log($"�E");
    }

    private void OnEnterLeft(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // ��������
        // ���܂̌�����Ԃ𐼂�
        Debug.Log($"��");
    }

    private void OnEnterA(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // bearing��������
        // GetBearing
        Debug.Log($"A������");
    }

    private void OnExitA(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // bearing�������
        // CheckBearingDirection
        Debug.Log($"A������");
    }
}
