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
        // 各ボタンのイベントで呼ぶ関数を設定
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
        // 北を向く
        m_bear.SetDirection(E_Direction.Up);
        Debug.Log($"上");
    }

    private void OnEnterDown(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // 南を向く
        m_bear.SetDirection(E_Direction.Down);
        Debug.Log($"下");
    }

    private void OnEnterRight(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // 右を向く
        m_bear.SetDirection(E_Direction.Right);
        Debug.Log($"右");
    }

    private void OnEnterLeft(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // 左を向く
        m_bear.SetDirection(E_Direction.Left);
        Debug.Log($"左");
    }

    private void OnEnterA(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // bearingを持った
        // GetBearing
        Debug.Log($"A押した");
    }

    private void OnExitA(InputAction.CallbackContext context)
    {
        if (!m_gameManager.GetIsControl()) return;
        // bearingを持っていなければ行わない
        if (m_bearing == null) return;
        // 
        if (true)
        {
            m_gameManager.AddScore();
        }
        // bearingを放した
        // CheckBearingDirection
        Debug.Log($"A放した");
    }
}
