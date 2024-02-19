using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingController : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet;
    [SerializeField] private float m_shootingRate;
    [SerializeField] private float m_bulletSpeed;
    private PauseController m_PauseController;

    // Start is called before the first frame update
    
    void Start()
    {
        m_PauseController = FindObjectOfType<PauseController>();
    }

    // Update is called once per frame
    void Update()
    {
            if(!m_PauseController.IsPaused)
        {
            

       
            if (Input.GetKeyDown(KeyCode.Space))
         {
            InvokeRepeating("Shoot", 0.0f, m_shootingRate);
         }
            if (Input.GetKeyUp(KeyCode.Space))
          {
            CancelInvoke();
          }
        }
    }

    private void Shoot()
    {
        GameObject newBullet = Instantiate(m_bullet, transform.position +Vector3.up, Quaternion.identity);
        newBullet.GetComponent<BulletController>().Init(m_bulletSpeed);
    }
}
