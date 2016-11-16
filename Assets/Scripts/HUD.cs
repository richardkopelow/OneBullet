using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text HasBulletText;

    Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }
    
    void Update()
    {
        HasBulletText.text = player.HasBullet ? "Has Bullet" : "No Bullet";
    }
}
