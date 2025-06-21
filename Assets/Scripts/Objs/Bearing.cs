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

        // 全て非表示
        foreach (GameObject bearObj in m_bearingDrawObjs)
        {
            bearObj.SetActive(false);
        }
        // ランダムなベアリングを設定
        m_bearingNum = UnityEngine.Random.Range(0, 3);
        m_bearingDrawObjs[m_bearingNum].SetActive(true);

        // スポナーを取得
        var bearingSpawnerObj = GameObject.Find("BearingSpawner");
        m_bearingSpawner = bearingSpawnerObj.GetComponent<BearingSpawner>();
        
        // 現在の速度をスポナーから受け取る
        m_moveSpeed = m_bearingSpawner.GetCrrentBSpeed();

        m_bearingStatus = E_BearingStatus.Default;
    }

    void Update()
    {
        // 移動
        switch (m_bearingStatus)
        {
            // コンベアに合わせる
            case E_BearingStatus.Default:
                m_newPos = transform.position;
                m_newPos.x += m_moveSpeed * Time.deltaTime;
                transform.position = m_newPos;
                break;
            // 自分では移動しない
            case E_BearingStatus.Have:
                break;
            // 自身のベアリング番号に合わせて動く
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
            // 右（X+）
            case 0:
                m_newPos.x += m_moveSpeed * Time.deltaTime;
                break;
            // 上（Z+）
            case 1:
                m_newPos.z += m_moveSpeed * Time.deltaTime;
                break;
            // 下（Z-）
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
                // HPを減らす
                m_gameManager.SubPlayerHP();
                Destroy(gameObject);
            }
        }
    }
}
