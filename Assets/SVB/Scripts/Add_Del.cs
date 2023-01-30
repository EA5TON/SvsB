using TMPro;
using UnityEngine;
using Random = System.Random;

public class Add_Del: MonoBehaviour
{
    [SerializeField] int Length = 1;
    [SerializeField] Tail Component_Tail;
    [SerializeField] TextMeshPro Text;

    [SerializeField] GameObject Win;
    [SerializeField] GameObject Lose;

    [SerializeField] Controls Component_Controls;

    //------------------------------------------------------------------------------------------------------------------------
    void Start ()
    {
        Text.SetText (Length.ToString ());
    }
    //------------------------------------------------------------------------------------------------------------------------
    void FixedUpdate ()
    {
        if (Length <= 0)
        {
            Component_Controls.Die = true;
            Text.SetText (Length.ToString ());
            Lose.SetActive (true);
        }
    }
    //------------------------------------------------------------------------------------------------------------------------
    void OnTriggerEnter (Collider other)
    {

        int i;

        Random rand = new ();

        if (other.TryGetComponent (out Del del))
        {
            for (i = 0; i < GetRand (rand).Next (1, 11); i++)
            {
                Length--;
                Component_Tail.Remove_Circle ();
                Text.SetText (Length.ToString ());
            }
        }

        if (other.TryGetComponent (out Add add))
        {
            for (i = 0; i < GetRand (rand).Next (1, 11); i++)
            {
                Length++;
                Component_Tail.Add_Circles ();
                Text.SetText (Length.ToString ());
            }
        }
    }
    //------------------------------------------------------------------------------------------------------------------------
    static Random GetRand (Random rand)
    {
        return rand;
    }
    //------------------------------------------------------------------------------------------------------------------------
}