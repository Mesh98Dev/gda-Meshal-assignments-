using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    private ScoreCounter m_scoreCounter;

   // private AudioSource m_EnemyHitSource;
    //private GameObject MyAudioPlayerPrefab;
  
  
    //EnemyHitAudio enemyHitSoundPlayer;



    // Start is called before the first frame update
    void Start()
    {
        m_scoreCounter = FindObjectOfType<ScoreCounter>();
        //StartCoroutine(MovementCoroutine());
       
       //m_EnemyHitSource = GetComponent<AudioSource>();
       
       //myAudioPlayer = FindObjectOfType<EnemyHitAudio>(MyAudioPlayerPrefab)

        

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
           
         //myAudioPlayerPrefab
         
            //var soundHit = Instantiate( enemyHitSoundPlayer, transform.position, Quaternion.identity);

            Destroy(gameObject);
    
            
        }
    }
}
