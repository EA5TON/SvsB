using TMPro;
using UnityEngine;
using Random = System.Random;

public class Del: MonoBehaviour
{
    int i;
    readonly Random rand = new ();

    [SerializeField] internal int Length_Blocks = 1;
    [SerializeField] TMP_Text Text_Block;

    //------------------------------------------------------------------------------------------------------------------------
    void Start ()
    {
        for (i = 0; i < GetRand (rand).Next (1, 11); i++)
        {
            Length_Blocks++;
            Text_Block.SetText (Length_Blocks.ToString ());
        }
    }
    //------------------------------------------------------------------------------------------------------------------------
    void OnTriggerEnter (Collider other)
    {
        Destroy (gameObject);
    }
    //------------------------------------------------------------------------------------------------------------------------
    static Random GetRand (Random rand)
    {
        return rand;
    }
    //------------------------------------------------------------------------------------------------------------------------
}