using UnityEngine;
using System.Collections;

public class BounceSwitch : MonoBehaviour {
    public GameObject Target;
    public string Event = "Activate";
    public MeshRenderer lightRenderer;
    float lightIntensity;

    void Start()
    {
        lightIntensity = lightRenderer.material.GetColor("_EmissionColor").r;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Bullet>() != null)
        {
            lightRenderer.material.SetColor("_EmissionColor", new Color(0, lightIntensity, 0));
            DynamicGI.UpdateMaterials(lightRenderer);
            Target.SendMessage(Event);
        }
    }
}
