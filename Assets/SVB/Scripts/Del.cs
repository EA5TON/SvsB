using TMPro;
using UnityEngine;
using Random = System.Random;

public class Del: MonoBehaviour
{
    int i;
    readonly Random rand = new ();
    AudioSource Audio_Source;

    [SerializeField] internal int Length_Blocks = 1;
    [Space]
    [SerializeField] TMP_Text Text_Block;
    [Space]
    [SerializeField] GameObject Destroy_Blocks;
    [SerializeField] GameObject Snake;
    [Space]
    [SerializeField] AudioClip Audio_Clip;

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
        GameObject destroy_object = (GameObject) Instantiate (Destroy_Blocks);
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