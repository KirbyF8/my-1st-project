using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



/*
Exercise 1: Given two real numbers, display which one is the biggest in the console
Exercise 2: Given a lower case letter, display in the console if it’s a vowel or a consonant
Exercise 3: Given two integer numbers, display in the console if the first number is divisible by
the second number
Exercise 4: Given a variable which stores the value of a grade, display in the console the
corresponding letter (D = fail, C = passed, B = notable, A = excellent)
Exercise 5: Given three integer numbers (day, month and year), determine whether it is a valid
date
Exercise 6: Given a year, display in the console the corresponding Chinese year
Exercise 7: Given a day and a month, display in the console the corresponding horoscope
Exercise 8: Given a day of the week, determine whether it belongs to the weekend or not
Exercise 9: Given an age and a rank (gold, silver, bronze), display in the console the discount
to be applied:a
‣ If you are 65 or older and gold, you have a 75% discount
‣ If you are 65 or older and silver, you have a 50% discount
‣ If you are 65 or older and you are bronze, you have a 25% discount.t
‣ If you are under 65 years old and you are gold, you have a 50% discount
‣ If you are under 65 years old and you are silver, you have a 25% discount
‣ If you are under 65 years old and you are bronze, you have a 15% discount
‣ If you are under 18 years of age, you cannot be a member of the store and therefore
do not receive any discount
Exercise 10: Given 3 angles, indicate if they can be or not the internal angles of a triangle
(they must add up to exactly 180 degrees)
 */




public class Entrega3 : MonoBehaviour
{
    // Exercise 1
    [SerializeField]private float N1;
    [SerializeField]private float N2;
    private float mayor;
    private int[] hola;
    // Exercise 2
    [SerializeField] private string letra;

    // Exercise 3
    [SerializeField] private float IN1;
    [SerializeField] private float IN2;
    // Exercise 4
    [SerializeField] private float nota;
    // Exercise 5
    [SerializeField] private int Dia;
    [SerializeField] private int Mes;
    [SerializeField] private int Año;
    private bool Bisiestificaneitor;

    void Start()
    {

        // Exercise 1
        { 
       if (N1 > N2)
        {
            mayor = N1;
        }
       else if (N1 < N2)
        {
            mayor = N2;
        }
        else
        {
            Debug.Log("Son Iguales");
        }
        Debug.Log(mayor + "es mayor");
        }

        // Exercise 2
        {
            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Debug.Log("Vocal");
            }
            else
            {
                Debug.Log("Consonante");
            }
        }

        // Exercise 3
        {
            if (IN1 % IN2 == 0)
            {
                Debug.Log(IN1 + "es divisible por" + IN2);
            }
            else
            {
                Debug.Log(IN1 + "no es divisible por" + IN2);
            }
        }

        // Exercise 4
        {
            if (nota <= 4)
            {
                Debug.Log("D");
            }
            else if (nota <= 6)
            {
                Debug.Log("C");
            }
            else if (nota <= 8)
            {
                Debug.Log("B");
            }
            else if (nota <= 10)
            {
                Debug.Log("A");
            }
        }

        // Exercise 5
        {
            if (Año % 4 == 0 && Año % 100 == 0 && Año % 400 == 0 || Año % 4 == 0 && Año % 100 != 0)
            {
                Bisiestificaneitor = true;
            }
            else
            {
                Bisiestificaneitor = false;
            }

            if (Dia >= 32 || Mes >= 12 || Mes == 2 && Dia >= 29 && Bisiestificaneitor == false )
            {
                Debug.Log("Fecha no Válida");
            }
            else if(Dia == 31 )
            {
                if (Mes == 2)
                {
                    Debug.Log("Fecha no Válida");
                }
                if (Mes == 4)
                {
                    Debug.Log("Fecha no Válida");
                }
                if (Mes == 6)
                {
                    Debug.Log("Fecha no Válida");
                }
                if (Mes == 9)
                {
                    Debug.Log("Fecha no Válida");
                }
                if (Mes == 11)
                {
                    Debug.Log("Fecha no Válida");
                }
            }
            else
            {
                Debug.Log("Fecha Válida");
            }
        }
    
    }

    // Update is called once per frame
    
}
