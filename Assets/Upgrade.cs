using UnityEngine;

public class Upgrade: MonoBehaviour
{
    void OnTriggerEnter ()
    {
        Destroy (gameObject);
    }
}