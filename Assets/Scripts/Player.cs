using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public Transform Cam;
    public Rigidbody BulletPrefab;
    public float BulletSpeed = 20;
    public bool HasBullet = true;

    void Start()
    {

    }

    void Update()
    {
        if (HasBullet && Input.GetMouseButtonDown(0))
        {
            Rigidbody bullRig = Instantiate(BulletPrefab);
            bullRig.GetComponent<Transform>().position = Cam.position + Cam.forward * 1f;
            bullRig.velocity = 20 * Cam.forward;
            HasBullet = false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Bullet>() != null)
        {
            HasBullet = true;
        }
    }
}
