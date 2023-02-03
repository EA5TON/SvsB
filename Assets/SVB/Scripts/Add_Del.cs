using TMPro;
using UnityEngine;
using Random = System.Random;

public class Add_Del: MonoBehaviour
{
    int i;
    readonly Random rand = new ();

    [SerializeField] int Length_Snake = 1;
    [Space]
    [SerializeField] TMP_Text Text_Snake;
    [SerializeField] Tail Component_Tail;
    [SerializeField] Controls Component_Controls;
    [SerializeField] Del Component_Del;
    [Space]
    [SerializeField] GameObject Win;
    [SerializeField] GameObject Lose;

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
            for (i = 0; i < Component_Del.Length_Blocks; i++)
            {
                Length_Snake--;
                Component_Tail.Remove_Circle ();
                Text_Snake.SetText (Length_Snake.ToString ());
            }
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