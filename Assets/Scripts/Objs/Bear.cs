using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    private E_Direction m_direction;
    public void SetDirection(E_Direction Direction) 
    {  
        m_direction = Direction;

        switch (m_direction)
        {
            case E_Direction.Up:
                transform.rotation = Quaternion.Euler(0.0f, 270.0f, 0.0f);
                break;
            case E_Direction.Down:
                transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
                break;
            case E_Direction.Left:
                transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
                break;
            case E_Direction.Right:
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                break;
        }
    }
    public E_Direction GetDirection() { return m_direction; }

    // Start is called before the first frame update
    void Start()
    {
        m_direction = E_Direction.Left;
    }

    // Update is called once per frame
    void Update()
    {
        switch(m_direction)
        {
            case E_Direction.Up:
                transform.rotation = Quaternion.Euler(0.0f, 270.0f, 0.0f);
                break;
            case E_Direction.Down:
                transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
                break;
            case E_Direction.Left:
                transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
                break;
            case E_Direction.Right:
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                break;
        }
    }
}
