using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameSceneInputManager : MonoBehaviour
{
    private InputActions m_inputActions;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        // 各ボタンのイベントで呼ぶ関数を設定
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
        // 北を向く
        // くまを回転
        // くまの向き状態を北に
        Debug.Log($"上");
    }

    private void OnEnterDown(InputAction.CallbackContext context)
    {
        // 南を向く
        // くまを回転
        // くまの向き状態を南に
        Debug.Log($"下");
    }

    private void OnEnterRight(InputAction.CallbackContext context)
    {
        // 右を向く
        // くまの向き状態を東に
        Debug.Log($"右");
    }

    private void OnEnterLeft(InputAction.CallbackContext context)
    {
        // 左を向く
        // くまの向き状態を西に
        Debug.Log($"左");
    }

    private void OnEnterA(InputAction.CallbackContext context)
    {
        // bearingを持った
        // GetBearing
        Debug.Log($"A押した");
    }

    private void OnExitA(InputAction.CallbackContext context)
    {
        // bearingを放した
        // CheckBearingDirection
        Debug.Log($"A放した");
    }
}
