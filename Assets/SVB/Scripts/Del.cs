using TMPro;
using UnityEngine;
using Random = System.Random;

public class Del: MonoBehaviour
{
    int i;
    readonly Random rand = new ();
    AudioSource Audio_Source;

    [SerializeField] GameObject Snake;
    [SerializeField] AudioClip Audio_Clip;
    [SerializeField] internal int Length_Blocks = 1;
    [SerializeField] TMP_Text Text_Block;

    //------------------------------------------------------------------------------------------------------------------------
    void Start ()
    {
        Audio_Source = Snake.GetComponent <AudioSource> ();

        for (i = 0; i < GetRand (rand).Next (1, 11); i++)
        {
            Length_Blocks++;
            Text_Block.SetText (Length_Blocks.ToString ());
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