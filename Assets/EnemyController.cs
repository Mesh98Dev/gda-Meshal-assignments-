using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyController : MonoBehaviour
{

    private ScoreCounter m_scoreCounter;
    [SerializeField] private EnemyData m_data;
    [SerializeField] private Image m_healthBar;
     int m_health;


    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {   
        m_health = m_data.Health;
        m_scoreCounter = FindObjectOfType<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            --m_health;
            m_healthBar.fillAmount = m_health / (float)m_data.Health;
            if(m_health <= 0)
            {
                m_scoreCounter.IncreaseCounter();
                Destroy(gameObject);
            }
            
        }
    }
}
