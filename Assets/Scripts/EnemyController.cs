using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    private ScoreCounter m_scoreCounter;

    AudioSource m_EnemyHitSource;
    

    // Start is called before the first frame update
    void Start()
    {
        m_scoreCounter = FindObjectOfType<ScoreCounter>();
        //StartCoroutine(MovementCoroutine());
       
       m_EnemyHitSource = GetComponent<AudioSource>();

        

    }

    private IEnumerator MovementCoroutine()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        while (true)
        {
            for (int i = 0; i < 200; i++)
            {
                rb.velocity = Vector3.up;
                yield return new WaitForFixedUpdate();
            }

            for (int i = 0; i < 200; i++)
            {
                rb.velocity = Vector3.zero;
                yield return new WaitForFixedUpdate();
            }

            for (int i = 0; i < 200; i++)
            {
                rb.velocity = Vector3.down;
                yield return new WaitForFixedUpdate();
            }

            for (int i = 0; i < 200; i++)
            {
                rb.velocity = Vector3.zero;
                yield return new WaitForFixedUpdate();
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            //m_EnemyHitSource.Play();

            m_scoreCounter.IncreaseCounter();
           
         
            Instantiate(myAudioPlayerPewfab, transform.position, Quaternion.identity);

            Destroy(gameObject);
    
            
        }
    }
}
