using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private InputActions m_inputActions;

    private void Awake()
    {
        m_inputActions = new InputActions();

        // �\���L�[��̉�������OnUp()���Ă�
        m_inputActions.GameScene.Up.started    += OnUp;
        m_inputActions.GameScene.Down.started  += OnDown;
        m_inputActions.GameScene.Right.started += OnRight;
        m_inputActions.GameScene.Left.started  += OnLeft;

        m_inputActions.GameScene.A.started  += OnSA;
        m_inputActions.GameScene.A.canceled += OnCA;

        m_inputActions.Enable();
    }

    private void OnDestroy()
    {
        // ���g�ŃC���X�^���X������Action�N���X��IDisposable���������Ă���̂ŁA
        // �K��Dispose����K�v������
        m_inputActions?.Dispose();
    }

    private void OnUp(InputAction.CallbackContext context)
    {
        // �k������
        // ���܂���]
        // �����t���O��k��
        Debug.Log($"��");
    }

    private void OnDown(InputAction.CallbackContext context)
    {
        // �k������
        // ���܂���]
        // �����t���O����
        Debug.Log($"��");
    }

    private void OnRight(InputAction.CallbackContext context)
    {
        // �k������
        // ���܂���]
        // �����t���O�𓌂�
        Debug.Log($"�E");
    }

    private void OnLeft(InputAction.CallbackContext context)
    {
        // �k������
        // ���܂���]
        // �����t���O�𐼂�
        Debug.Log($"��");
    }

    private void OnSA(InputAction.CallbackContext context)
    {
        
        // ���܂���]
        // �����t���O�𐼂�
        Debug.Log($"A������");
    }

    private void OnCA(InputAction.CallbackContext context)
    {
        
        // ���܂���]
        // �����t���O�𐼂�
        Debug.Log($"A������");
    }
}
