using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bearing : MonoBehaviour
{
    private GameObject[] m_bearingDrawObjs;
    private BearingSpawner m_bearingSpawner;

    private float m_moveSpeed;
    private int idx = 0;

    void Start()
    {
        m_bearingDrawObjs = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            m_bearingDrawObjs[i] = transform.GetChild(i).gameObject;
        }

        // ‘S‚Ä”ñ•\Ž¦
        foreach (GameObject bearObj in m_bearingDrawObjs)
        {
            bearObj.SetActive(false);
        }

        idx = UnityEngine.Random.Range(0, 3);
        m_bearingDrawObjs[idx].SetActive(true);

        var bearingSpawnerObj = GameObject.Find("BearingSpawner");
        m_bearingSpawner = bearingSpawnerObj.GetComponent<BearingSpawner>();

        m_moveSpeed = m_bearingSpawner.GetCrrentBSpeed();
    }

    void Update()
    {
        
    }
}
