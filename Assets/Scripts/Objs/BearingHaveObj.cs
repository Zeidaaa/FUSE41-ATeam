using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearingHaveObj : MonoBehaviour
{
    private Bearing m_bearing;

    public Bearing GetBearing() { return m_bearing; }

    // Start is called before the first frame update
    void Start()
    {
        m_bearing = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionStay(Collision collision)
    {
        if (collision == null) return;

        var other = collision.gameObject;

        if (other.CompareTag("Bearing"))
        {
            Debug.Log("Log1");
            if (m_bearing == null)
            {
                Debug.Log("Log2");
                m_bearing = other.GetComponent<Bearing>();
            }
            else
            {
                Debug.Log("Log3");

                if (other == m_bearing) return;

                if (other.transform.position.x > m_bearing.transform.position.x)
                {
                    Debug.Log("Log4");
                    m_bearing = other.GetComponent<Bearing>();
                }
            }
        }
    }
}
