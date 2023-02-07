using UnityEngine;

public class Play_Sounds: MonoBehaviour
{
    [SerializeField] internal AudioSource Audio_Upgrade;
    [SerializeField] internal AudioSource Audio_Destroy;

    [SerializeField] Del Component_Del;
    [SerializeField] Add Component_Add;

    //------------------------------------------------------------------------------------------------------------------------
    void Start ()
    {
        Audio_Upgrade = GetComponent <AudioSource> ();
        Audio_Destroy = GetComponent <AudioSource> ();
    }
    //------------------------------------------------------------------------------------------------------------------------
    void OnTriggerEnter (Collider other)
    {
        if (other.TryGetComponent (out Del Component_Del))
        {
            Audio_Destroy.Play ();
        }

        if (other.TryGetComponent (out Add Component_Add))
        {
            Audio_Upgrade.Play ();
        }
    }
    //------------------------------------------------------------------------------------------------------------------------
}
