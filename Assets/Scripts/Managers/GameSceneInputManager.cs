using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameSceneInputManager : MonoBehaviour
{
    [SerializeField]
    private Bear m_bear;

    private Bearing m_bearing;

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

        m_bearing = null;

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
        m_bear.SetDirection(E_Direction.Up);
        Debug.Log($"��");
    }

    private void OnEnterDown(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // �������
        m_bear.SetDirection(E_Direction.Down);
        Debug.Log($"��");
    }

    private void OnEnterRight(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // �E������
        m_bear.SetDirection(E_Direction.Right);
        Debug.Log($"�E");
    }

    private void OnEnterLeft(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // ��������
        m_bear.SetDirection(E_Direction.Left);
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
        // bearing�������Ă��Ȃ���΍s��Ȃ�
        if (m_bearing == null) return;
        // 
        if (true)
        {
            m_gameManager.AddScore();
        }
        // bearing�������
        // CheckBearingDirection
        Debug.Log($"A������");
    }
}
