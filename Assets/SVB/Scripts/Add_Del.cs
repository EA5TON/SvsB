using TMPro;
using UnityEngine;

public class Add_Del: MonoBehaviour
{
    int i;

    [SerializeField] int Length_Snake = 1;
    [Space]
    [SerializeField] TMP_Text Text_Snake;
    [Space]
    [SerializeField] Tail Component_Tail;
    [SerializeField] Controls Component_Controls;
    [SerializeField] Del Component_Del;
    [SerializeField] Add Component_Add;
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
            Invoke ("Lose_Game", 0.5f);
        }
    }
    //------------------------------------------------------------------------------------------------------------------------
    void OnTriggerEnter (Collider other)
    {
        if (other.TryGetComponent (out Del Component_Del))
        {
            for (i = 0; i < Component_Del.Length_Blocks; i++)
            {
                Length_Snake--;
                Component_Tail.Remove_Circle ();
                Text_Snake.SetText (Length_Snake.ToString ());
            }
        }

        if (other.TryGetComponent (out Add Component_Add))
        {
            for (i = 0; i < Component_Add.Length_Sphere; i++)
            {
                Length_Snake++;
                Component_Tail.Add_Circles ();
                Text_Snake.SetText (Length_Snake.ToString ());
            }
        }
    }
    //------------------------------------------------------------------------------------------------------------------------
    void Lose_Game ()
    {
        Lose.SetActive (true);
    }
    //------------------------------------------------------------------------------------------------------------------------
}