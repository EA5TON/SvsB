using UnityEngine;

public class Add: MonoBehaviour
{
    private void OnTriggerEnter ()
    {
        Destroy (gameObject);
    }
}