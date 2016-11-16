using UnityEngine;
using System.Collections;

public class BulletSwitch : MonoBehaviour
{
    public GameObject Target;
    public string Event = "Activate";

    MeshRenderer renderer;
    float lightIntensity;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        lightIntensity = renderer.material.GetColor("_EmissionColor").r;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Bullet>() != null)
        {
            renderer.material.SetColor("_EmissionColor", new Color(0, lightIntensity, 0));
            DynamicGI.UpdateMaterials(renderer);
            Target.SendMessage(Event);
        }
    }
}
