using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "Bounce")
        {
            Destroy(gameObject);
        }
    }
}
