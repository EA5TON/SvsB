using TMPro;
using UnityEngine;
using Random = System.Random;

public class Add: MonoBehaviour
{
    int i;
    readonly Random rand = new ();
    AudioSource Audio_Source;

    [SerializeField] GameObject Snake;
    [SerializeField] AudioClip Audio_Clip;
    [SerializeField] internal int Length_Sphere = 1;
    [SerializeField] TMP_Text Text_Sphere;

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
        Destroy (gameObject);
    }
    //------------------------------------------------------------------------------------------------------------------------  
    static Random GetRand (Random rand)
    {
        return rand;
    }
    //------------------------------------------------------------------------------------------------------------------------  
}