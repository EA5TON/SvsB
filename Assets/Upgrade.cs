using UnityEngine;

public class Upgrade : MonoBehaviour
{

    void OnTriggerEnter ()
    {
        Input.GetKeyDown (KeyCode.A);
        Debug.Log ("A");
    }
}