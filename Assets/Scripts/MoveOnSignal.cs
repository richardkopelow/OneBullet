using UnityEngine;
using System.Collections;

public class MoveOnSignal : MonoBehaviour
{
    public Vector3 Amount;
    public float MoveTime;

    Transform trans;

    void Start()
    {
        trans = GetComponent<Transform>();
    }

    public void Move()
    {
        StartCoroutine(move());
    }
    IEnumerator move()
    {
        float time = 0;
        while (time < MoveTime)
        {
            trans.Translate(Amount * Time.deltaTime / MoveTime);
            time += Time.deltaTime;
            yield return null;
        }
    }
}
