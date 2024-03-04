using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShootingController : MonoBehaviour
{
    public string Name { get; private set; }

    [SerializeField] private Animator m_animator;
    [SerializeField] private GameObject m_bullet;
    [SerializeField] private float m_shootingRate;
    [SerializeField] private float m_bulletSpeed;
    [SerializeField] AudioSource  m_shootingSource;

    private PauseController m_pauseController;

    // Start is called before the first frame update
    void Start()
    {
        m_pauseController = FindObjectOfType<PauseController>();
        
        m_shootingSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!m_pauseController.IsPaused)
        {
            if (Input.GetMouseButtonDown((int)MouseButton.Left))
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
        m_shootingSource.Play();
    }
}
