using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    [SerializeField] private string animal;
    [SerializeField] private int legs;
    [SerializeField] private string gender;




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(string.Format("{2} {0} tiene {1} patas", animal, legs, gender));
    }

}
