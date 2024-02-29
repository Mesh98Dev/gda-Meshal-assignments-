using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationHandller : MonoBehaviour
{
    // Start is called before the first frame update
    
        private PlayerShootingController m_shootingController;
        private void Awake()
        {
            m_shootingController = GetComponentInParent<PlayerShootingController>();
        }
        void ShootBullet()
        {
            m_shootingController.Shoot();
        }
}
