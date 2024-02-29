using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingController : MonoBehaviour
{
    public string Name { get; private set; }

    [SerializeField] private Animator m_animator;
    [SerializeField] private GameObject m_bullet;
    [SerializeField] private float m_shootingRate;
    [SerializeField] private float m_bulletSpeed;

    private PauseController m_pauseController;

    // Start is called before the first frame update
    void Start()
    {
        m_pauseController = FindObjectOfType<PauseController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!m_pauseController.IsPaused)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                 m_animator.SetTrigger("Shoot");
                //InvokeRepeating("Shoot", 0.0f, m_shootingRate);
            }
            /*
            if (Input.GetKeyUp(KeyCode.Space))
            {
                CancelInvoke();
            }*/
        }
    }

    public void Shoot()
    {
        GameObject newBullet = Instantiate(m_bullet, transform.position, Quaternion.identity);
        newBullet.GetComponent<BulletController>().Init(m_bulletSpeed, false, false);
    }
}
