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

        // 十字キー上の押下時にOnUp()を呼ぶ
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
        // 自身でインスタンス化したActionクラスはIDisposableを実装しているので、
        // 必ずDisposeする必要がある
        m_inputActions?.Dispose();
    }

    private void OnUp(InputAction.CallbackContext context)
    {
        // 北を向く
        // くまを回転
        // 向きフラグを北に
        Debug.Log($"上");
    }

    private void OnDown(InputAction.CallbackContext context)
    {
        // 北を向く
        // くまを回転
        // 向きフラグを南に
        Debug.Log($"下");
    }

    private void OnRight(InputAction.CallbackContext context)
    {
        // 北を向く
        // くまを回転
        // 向きフラグを東に
        Debug.Log($"右");
    }

    private void OnLeft(InputAction.CallbackContext context)
    {
        // 北を向く
        // くまを回転
        // 向きフラグを西に
        Debug.Log($"左");
    }

    private void OnSA(InputAction.CallbackContext context)
    {
        
        // くまを回転
        // 向きフラグを西に
        Debug.Log($"A押した");
    }

    private void OnCA(InputAction.CallbackContext context)
    {
        
        // くまを回転
        // 向きフラグを西に
        Debug.Log($"A放した");
    }
}
