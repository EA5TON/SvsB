using TMPro;
using UnityEngine;
using Random = System.Random;

public class Add_Del: MonoBehaviour
{
    int i;
    readonly Random rand = new ();

    [SerializeField] internal int Length_Snake = 1;
    [SerializeField] Del Component_Del;
    [SerializeField] Tail Component_Tail;
    [SerializeField] internal TMP_Text Text_Snake;

    [SerializeField] GameObject Win;
    [SerializeField] GameObject Lose;

    [SerializeField] Controls Component_Controls;

    //------------------------------------------------------------------------------------------------------------------------
    void Start ()
    {
        Text_Snake.SetText (Length_Snake.ToString ());
    }
    //------------------------------------------------------------------------------------------------------------------------
    void FixedUpdate ()
    {
        if (Length_Snake <= 0)
        {
            Component_Controls.Die = true;
            Text_Snake.SetText (Length_Snake.ToString ());
            Lose.SetActive (true);
        }
    }
    //------------------------------------------------------------------------------------------------------------------------
    void OnTriggerEnter (Collider other)
    {
        if (other.TryGetComponent (out Del del))
        {
            //for (i = 0; i < GetRand (rand).Next (1, 11); i++)
            //{
                Length_Snake = Length_Snake - Component_Del.Length_Blocks;
                Length_Snake--;
                Component_Tail.Remove_Circle ();
                Text_Snake.SetText (Length_Snake.ToString ());
            //}
        }

        if (other.TryGetComponent (out Add add))
        {
            for (i = 0; i < GetRand (rand).Next (1, 11); i++)
            {
                Length_Snake++;
                Component_Tail.Add_Circles ();
                Text_Snake.SetText (Length_Snake.ToString ());
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