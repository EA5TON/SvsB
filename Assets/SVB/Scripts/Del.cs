using UnityEngine;

public class Del: MonoBehaviour
{
    private void OnTriggerEnter (Collider other)
    {
        Destroy (gameObject);
    }
}