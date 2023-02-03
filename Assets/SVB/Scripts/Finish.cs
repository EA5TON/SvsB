using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish: MonoBehaviour
{
    [SerializeField] GameObject Win;
    [SerializeField] Controls Component_Controls;
    //------------------------------------------------------------------------------------------------------------------------
    void OnTriggerEnter ()
    {
        Component_Controls.Die = true;
        Win.SetActive (true);
    }
    //------------------------------------------------------------------------------------------------------------------------
    public void Button_Next_Level ()
    {
        Win.SetActive (false);
    }
    //------------------------------------------------------------------------------------------------------------------------
    public void Button_Main_Menu ()
    {
        SceneManager.LoadScene (0);
    }
    //------------------------------------------------------------------------------------------------------------------------
}
