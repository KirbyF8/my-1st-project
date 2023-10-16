using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega2 : MonoBehaviour
{
    /* Exercise 1: Create a two private variables that store real numbers and assign them a value in
 the inspector
  Exercise 2: Sum the two variables and display the result in the console
  Exercise 3: Compare if the first variable you have created is greater than or equal to the
 second one and display the result in the console
  Exercise 4: Store in a new variable the result of the comparison of the previous exercise
  Exercise 5: Create a private variable that stores your name
 Exercise 6: Display in the console a welcome message to you using the variable created in
 the previous exercise
  Exercise 7: Create a two private variables that store integer numbers and assign them a value
 in the inspector
  Exercise 8: Calculate the first variable modulo the second variable and display the result in
 the console
  Exercise 9: Show in the console the message: “Hello! My name is _”, where _ is the content
 of the variable created in exercise 5
  Exercise 10: Indicate with comments which is the solution to each of the previous exercises*/


    //  Exercise 1 // This creates two variables and with the serializefield make that we can change it in Unity
    [SerializeField] private float N1;
    [SerializeField] private float N2;
    //   Exercise 2 
    private float resultado;
    //   Exercise 3 & 4
    private bool comparador;
    // Exercise 5
    private string nombre = "Héctor";
    // Exercise 7 & 8
    [SerializeField] private int N3;
    [SerializeField] private int N4;
    private int resultado2;
    
    void Start()
    {
        //   Exercise 2 First put the result of N1 plus N2 in "resultado" , then whith Debug.Log show it in the console
        resultado = N1 + N2;
        Debug.Log(resultado);

        // Exercise 3 & 4 // Compares if N1 is equal or greater than N2, then save the result in "comparador"
        if (N1 >= N2)
        {
            comparador = true;
            Debug.Log(comparador);
        }
        // Exercise 6 // This add "nombre" to Welcome
        Debug.Log("Welcome " + nombre );
        // Exercise 8 // First put the result of N3 multiplied N4 in "resultado2" , then whith Debug.Log show it in the console
        resultado2 = N3 * N4;  
        Debug.Log (resultado2);
        // Exercise 9 
        Debug.Log("Hello! My name is " + nombre);
    }


}
