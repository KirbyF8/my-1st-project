using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEditor.VersionControl;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    [SerializeField] private string username;
    [SerializeField] private float n�1;
    [SerializeField] private float n�2;
    [SerializeField] private int coins;
    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log(username);

        // Forma 1
        Debug.Log(message:$"El nombre de usuario es: {username}");
        // Forma 2
        // Debug.Log(message: $"El nombre de usuario es: {0}",username);
        // Forma 3
        Debug.Log(message: $"El nombre de usuario es:" + username + " si");
         */

        Debug.Log(2 + 5);
        Debug.Log(2 - 6);
        Debug.Log(2 * 7);
        Debug.Log(8 / 2);
        Debug.Log( n�1 + n�2);

        Debug.Log(coins);
        coins += 99;
        Debug.Log(coins);
        
    } 
}

// Debug.Log("Lo que quieras que aparezca por consola");
