using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditorInternal.ReorderableList;

public class Bearing : MonoBehaviour
{
    private GameObject[] m_bearingDrawObjs;
    private BearingSpawner m_bearingSpawner;
    private GameManager m_gameManager;

    private Vector3 m_newPos;

    private float m_moveSpeed;
    private int m_bearingNum = 0;

    public enum E_BearingStatus
    {
        Default,
        Have,
        Answer
    }

    private E_BearingStatus m_bearingStatus;
    public void SetBearingStatus(E_BearingStatus BearingStatus) { m_bearingStatus = BearingStatus; }
    public E_BearingStatus GetBearingStatus() { return m_bearingStatus; }

    void Start()
    {
        var gameManagerObj = GameObject.Find("GameManager");
        m_gameManager = gameManagerObj.GetComponent<GameManager>();

        m_bearingDrawObjs = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            m_bearingDrawObjs[i] = transform.GetChild(i).gameObject;
        }

        // �S�Ĕ�\��
        foreach (GameObject bearObj in m_bearingDrawObjs)
        {
            bearObj.SetActive(false);
        }
        // �����_���ȃx�A�����O��ݒ�
        m_bearingNum = UnityEngine.Random.Range(0, 3);
        m_bearingDrawObjs[m_bearingNum].SetActive(true);

        // �X�|�i�[���擾
        var bearingSpawnerObj = GameObject.Find("BearingSpawner");
        m_bearingSpawner = bearingSpawnerObj.GetComponent<BearingSpawner>();
        
        // ���݂̑��x���X�|�i�[����󂯎��
        m_moveSpeed = m_bearingSpawner.GetCrrentBSpeed();

        m_bearingStatus = E_BearingStatus.Default;
    }

    void Update()
    {
        // �ړ�
        switch (m_bearingStatus)
        {
            // �R���x�A�ɍ��킹��
            case E_BearingStatus.Default:
                m_newPos = transform.position;
                m_newPos.x += m_moveSpeed * Time.deltaTime;
                transform.position = m_newPos;
                break;
            // �����ł͈ړ����Ȃ�
            case E_BearingStatus.Have:
                break;
            // ���g�̃x�A�����O�ԍ��ɍ��킹�ē���
            case E_BearingStatus.Answer:
                BearingNumMove();
                break;
            default:
                break;
        }
    }

    private void BearingNumMove()
    {
        m_newPos = transform.position;
        switch(m_bearingNum)
        {
            // �E�iX+�j
            case 0:
                m_newPos.x += m_moveSpeed * Time.deltaTime;
                break;
            // ��iZ+�j
            case 1:
                m_newPos.z += m_moveSpeed * Time.deltaTime;
                break;
            // ���iZ-�j
            case 2:
                m_newPos.z -= m_moveSpeed * Time.deltaTime;
                break;
            default:
                break;
        }
        transform.position = m_newPos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null)
        {
            var other =  collision.gameObject;

            if (other.CompareTag("Ground"))
            {
                // HP�����炷
                m_gameManager.SubPlayerHP();
                Destroy(gameObject);
            }
        }
    }
}
