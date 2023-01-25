using System.Collections.Generic;
using UnityEngine;

public class Tail: MonoBehaviour
{
    int i;

    [SerializeField] private Transform Head;
    [SerializeField] private float Diametr;

    private readonly List <Transform> Snake_Sircles = new ();
    private readonly List <Vector3> positions = new ();

    void Start ()
    {
        positions.Add (Head.position);
        Add_Circles ();
        Add_Circles ();
    }

    void Update ()
    {
        float distance = ((Vector3) Head.position - positions [0]).magnitude;

        if (distance > Diametr)
        {
            Vector3 direction = ((Vector3) Head.position - positions [0]).normalized;
            positions.Insert (0, positions [0] + direction * Diametr);
            positions.RemoveAt (positions.Count - 1);

            distance -= Diametr;
        }

        for (i = 0; i < Snake_Sircles.Count; i++)
        {
            Snake_Sircles [i].position = Vector3.Lerp (positions [i + 1], positions [i], distance / Diametr);
        }

        if (Input.GetKeyDown (KeyCode.A))
            Add_Circles ();

        if (Input.GetKeyDown (KeyCode.D))
            Remove_Circle ();
    }

    public void Add_Circles ()
    {
        Transform circle = Instantiate (Head, positions [positions.Count - 1], Quaternion.identity, transform);
        Snake_Sircles.Add (circle);
        positions.Add (circle.position);
    }

    public void Remove_Circle ()
    {
        Destroy(Snake_Sircles [0].gameObject);
        Snake_Sircles.RemoveAt (0);
        positions.RemoveAt (1);
    }
}