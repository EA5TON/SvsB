using TMPro;
using UnityEngine;
using Random = System.Random;

public class Add: MonoBehaviour
{
    int i;
    readonly Random rand = new ();
    AudioSource Audio_Source;

    [SerializeField] internal int Length_Sphere = 1;
    [Space]
    [SerializeField] TMP_Text Text_Sphere;
    [Space]
    [SerializeField] GameObject Destroy_Sphere;
    [SerializeField] GameObject Snake;
    [Space]
    [SerializeField] AudioClip Audio_Clip;

    //------------------------------------------------------------------------------------------------------------------------
    void Start ()
    {
        Audio_Source = Snake.GetComponent <AudioSource> ();

        for (i = 0; i < GetRand (rand).Next (1, 11); i++)
        {
            Length_Sphere++;
            Text_Sphere.SetText (Length_Sphere.ToString ());
        }
    }
    //------------------------------------------------------------------------------------------------------------------------
    void OnTriggerEnter ()
    {
        Audio_Source.PlayOneShot (Audio_Clip);
        GameObject destroy_object = (GameObject) Instantiate (Destroy_Sphere);
        destroy_object.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
        Destroy (gameObject);
    }
    //------------------------------------------------------------------------------------------------------------------------  
    static Random GetRand (Random rand)
    {
        return rand;
    }
    //------------------------------------------------------------------------------------------------------------------------  
}