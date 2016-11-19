using UnityEngine;
using System.Collections;

public class BulletBox : MonoBehaviour {

    public void OnCollisionEnter(Collision collision)
    {
        Player player = collision.collider.GetComponent<Player>();
        if (player != null)
        {
            player.HasBullet = true;
            Destroy(gameObject);
        }
    }
}
