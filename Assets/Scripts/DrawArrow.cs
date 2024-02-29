using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawArrow : MonoBehaviour
{
    [SerializeField] private Transform m_target;

    private void Update()
    {
        Vector3 start = transform.position;
        Vector3 end = m_target.position;
        Debug.DrawLine(start, end);

        Vector3 direction = end - start;
        direction *= 0.2f;

        Vector3 mid = end - direction;

        Vector3 perp1 = new Vector3( direction.z, direction.y, -direction.x);
        Vector3 perp2 = new Vector3(-direction.z, direction.y,  direction.x);

        Debug.DrawLine(end, mid + perp1);
        Debug.DrawLine(end, mid + perp2);
    }
}
