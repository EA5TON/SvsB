using UnityEngine;

public class Del: MonoBehaviour
{
    private void OnTriggerEnter ()
    {
        Destroy (gameObject);
    }
}
