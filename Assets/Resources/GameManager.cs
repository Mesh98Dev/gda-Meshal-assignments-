using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private static GameManager m_instance;
    private static GameManager Instance { get {

        if (m_instance==null){
            var prefab = Resources.Load<GameManager>("GameManager");
            m_instance = Instantiate(prefab);
        }
        return m_instance;
        }
        } 
            
            [SerializeField] private int m_enemyCount;
}
