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
    private BearingHaveObj m_bearingHaveObj;
    
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

        var gameManagerObj = GameObject.Find("GameManager");
        m_gameManager = gameManagerObj.GetComponent<GameManager>();

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

        if (m_bearing != null)
        {
            Debug.Log("1");
            m_bearing.SetHavePosition(m_bear.transform.GetChild(0).position);
        }
    }

    private void OnEnterDown(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // �������
        m_bear.SetDirection(E_Direction.Down);
        if (m_bearing != null)
        {
            m_bearing.SetHavePosition(m_bear.transform.GetChild(0).position);
        }
    }

    private void OnEnterRight(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // �E������
        m_bear.SetDirection(E_Direction.Right);
        if (m_bearing != null)
        {
            m_bearing.SetHavePosition(m_bear.transform.GetChild(0).position);
        }
    }

    private void OnEnterLeft(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // ��������
        m_bear.SetDirection(E_Direction.Left);

        if (m_bearing != null)
        {
            m_bearing.SetHavePosition(m_bear.transform.GetChild(0).position);
        }
    }

    private void OnEnterA(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // bearing��������
        m_bearing = m_bearingHaveObj.GetBearing();
        Debug.Log("Log1");
        if (m_bearing != null)
        {
            Debug.Log("Log2");
            m_bearing.SetBearingStatus(Bearing.E_BearingStatus.Have);
            m_bearing.SetHavePosition(m_bear.transform.GetChild(0).position);
        }
    }

    private void OnExitA(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // bearing�������Ă��Ȃ���΍s��Ȃ�
        if (m_bearing == null) return;
        
        // ����
        // �x�A�����O�̎d�����ԍ������܂̌����ƈ�v���Ă����
        if (m_bearing.GetBearingNum() == (int)m_bear.GetDirection())
        {
            m_gameManager.AddScore();
            m_bearing.SetBearingStatus(Bearing.E_BearingStatus.Answer);
            m_bearing = null;
            m_bearingHaveObj.SetNull();
        }
        // ���s
        else
        {
            m_gameManager.SubPlayerHP();
            m_bearing.OnDead();
            m_bearing = null;
        }
    }
}
