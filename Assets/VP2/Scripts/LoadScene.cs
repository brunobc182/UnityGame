using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour
{

    public Transform Target;
    public float minDis;
    public string Scene;
    public int NumeroCena;

    // Use this for initialization
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Target.position) <= (minDis + 1))
        {
            if (NumeroCena != 0)
            {
                Application.LoadLevel(NumeroCena);
            }
            else
                Application.LoadLevel(Scene);
        }
    }   
}
