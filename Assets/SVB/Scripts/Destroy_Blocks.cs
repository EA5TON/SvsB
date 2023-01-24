using UnityEngine;

public class Destroy_Blocks: MonoBehaviour
{

    void OnTriggerEnter ()
    {
        Destroy (gameObject);
    }
 }