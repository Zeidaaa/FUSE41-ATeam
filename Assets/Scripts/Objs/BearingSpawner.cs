using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class BearingSpawner : MonoBehaviour
{
    private GameManager m_gameManager;

    [SerializeField]
    private GameObject m_bearingPrefab;

    private float m_spawnTime;
    private float m_spawnCounter;

    [SerializeField]
    private float m_defaultBSpeed;
    private float m_crrentBSpeed;
    public float GetCrrentBSpeed() { return m_crrentBSpeed; }
    
    [SerializeField]
    private S_BSpeedChangeScore[] m_bSpeedChangeScoreList;

    void Start()
    {
        var gameManagerObj = GameObject.Find("GameManager");
        m_gameManager = gameManagerObj.GetComponent<GameManager>();

        m_spawnTime = Random.Range(2, 7);
        m_spawnCounter = 0;
        
        m_crrentBSpeed = m_defaultBSpeed;
    }

    void Update()
    {
        // ランダムな時間ごとにbearingを生成
        m_spawnCounter += Time.deltaTime;
        if (m_spawnCounter >= m_spawnTime)
        {
            // 生成
            Vector3 spawnerPos = GetComponent<Transform>().position;
            Instantiate(m_bearingPrefab, spawnerPos, Quaternion.identity);
            
            // Timerリセット
            m_spawnTime = Random.Range(2, 7);
            m_spawnCounter = 0;
        }
    }

    public void ChangeBearingSpeed()
    {
        int crrentMinScore = -1;
        int crrentIdx = -1;
        int resultIdx = 0;
        foreach(var bSpeedChangeScore in m_bSpeedChangeScoreList)
        {
            if (m_gameManager.GetScore() <= bSpeedChangeScore.ChangeScore)
            {
                if (bSpeedChangeScore.ChangeScore > crrentMinScore)
                {
                    crrentMinScore = bSpeedChangeScore.ChangeScore;
                    resultIdx = crrentIdx;
                }
            }

            crrentIdx++;
        }

        if (resultIdx == -1)
        {
            return;
        }
        else
        {
            m_crrentBSpeed = m_bSpeedChangeScoreList[resultIdx].ChangeSpeed;
            // スピードアップのUIを再生
        }
    }
}
