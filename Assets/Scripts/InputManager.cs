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
        
        m_inputActions.GameScene.Up.started    += OnEnterUp;
        m_inputActions.GameScene.Down.started  += OnEnterDown;
        m_inputActions.GameScene.Right.started += OnEnterRight;
        m_inputActions.GameScene.Left.started  += OnEnterLeft;

        m_inputActions.GameScene.A.started  += OnEnterA;
        m_inputActions.GameScene.A.canceled += OnExitA;

        m_inputActions.Enable();
    }

    private void OnDestroy()
    {
        m_inputActions?.Dispose();
    }

    private void OnEnterUp(InputAction.CallbackContext context)
    {
        // –k‚ğŒü‚­
        // ‚­‚Ü‚ğ‰ñ“]
        // ‚­‚Ü‚ÌŒü‚«ó‘Ô‚ğ–k‚É
        Debug.Log($"ã");
    }

    private void OnEnterDown(InputAction.CallbackContext context)
    {
        // “ì‚ğŒü‚­
        // ‚­‚Ü‚ğ‰ñ“]
        // ‚­‚Ü‚ÌŒü‚«ó‘Ô‚ğ“ì‚É
        Debug.Log($"‰º");
    }

    private void OnEnterRight(InputAction.CallbackContext context)
    {
        // ‰E‚ğŒü‚­
        // ‚­‚Ü‚ÌŒü‚«ó‘Ô‚ğ“Œ‚É
        Debug.Log($"‰E");
    }

    private void OnEnterLeft(InputAction.CallbackContext context)
    {
        // ¶‚ğŒü‚­
        // ‚­‚Ü‚ÌŒü‚«ó‘Ô‚ğ¼‚É
        Debug.Log($"¶");
    }

    private void OnEnterA(InputAction.CallbackContext context)
    {
        // bearing‚ğ‚Á‚½
        // GetBearing
        Debug.Log($"A‰Ÿ‚µ‚½");
    }

    private void OnExitA(InputAction.CallbackContext context)
    {
        // bearing‚ğ•ú‚µ‚½
        // CheckBearingDirection
        Debug.Log($"A•ú‚µ‚½");
    }
}
