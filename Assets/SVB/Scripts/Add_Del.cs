using TMPro;
using UnityEngine;

public class Add_Del: MonoBehaviour
{
    int i;
    //[SerializeField] AudioSource Audio_Upgrade;
    //[SerializeField] AudioSource Audio_Destroy;

    [SerializeField] int Length_Snake = 1;
    [Space]
    [SerializeField] TMP_Text Text_Snake;
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
        //Audio_Upgrade = GetComponent <AudioSource> ();
        //Audio_Destroy = GetComponent <AudioSource> ();

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
        if (other.TryGetComponent (out Del Component_Del))
        {
            for (i = 0; i < Component_Del.Length_Blocks; i++)
            {
                //Audio_Destroy.Play ();
                Length_Snake--;
                Component_Tail.Remove_Circle ();
                Text_Snake.SetText (Length_Snake.ToString ());
            }
        }

        if (other.TryGetComponent (out Add Component_Add))
        {
            for (i = 0; i < Component_Add.Length_Sphere; i++)
            {
                //Audio_Upgrade.Play ();
                Length_Snake++;
                Component_Tail.Add_Circles ();
                Text_Snake.SetText (Length_Snake.ToString ());
            }
        }
    }
    //------------------------------------------------------------------------------------------------------------------------
}