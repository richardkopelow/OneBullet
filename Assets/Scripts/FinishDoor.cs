using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinishDoor : MonoBehaviour
{
    public string NextLevel;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Player>() != null)
        {
            SceneManager.LoadScene(NextLevel);
        }
    }
}
