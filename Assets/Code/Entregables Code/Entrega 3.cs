﻿using System.Collections;
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
   
    // Exercise 2
    [SerializeField] private string letra;

    // Exercise 3
    [SerializeField] private float IN1;
    [SerializeField] private float IN2;
    
    // Exercise 4
    [SerializeField] private float nota;
    
    // Exercise 5, 6, 7
    [SerializeField] private int Dia;
    [SerializeField] private int Mes;
    [SerializeField] private int Año;
    private bool Bisiestificaneitor;
    private string animal;

    // Exercise 8
    private int Centuria;
    private int Decada;
    private int Diadificador;
    private int resto;
    private int resto2;

    // Exercise 9
    [SerializeField]private int age;
    [SerializeField]private string rank;

    // Exercise 10
    [SerializeField]private float angle1;
    [SerializeField]private float angle2;
    [SerializeField]private float angle3;
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

        // Exercise 6
        {
        if (Año % 12 == 0)
        {
            animal = "Monkey";
        }
        else if (Año%12 == 1)
        {
            animal = "Rooster";
        }
        else if (Año % 12 == 2)
        {
            animal = "Dog";
        }
        else if (Año%12 == 3)
        {
            animal = "Pig";
        }
        else if (Año % 12 == 4)
        {
            animal = "Rat";
        }
        else if (Año % 12 == 5)
        {
            animal = "Ox";
        }
        else if (Año % 12 == 6)
        {
            animal = "Tiger";
        }
        else if (Año % 12 == 7)
        {
            animal = "Rabbit";
        }
        else if (Año % 12 == 8)
        {
            animal = "Dragon";
        }
        else if (Año % 12 == 9)
        {
            animal = "Snake";
        }
        else if (Año % 12 == 10)
        {
            animal = "Horse";
        }
        else
        {
            animal = "Sheep";
        }
        Debug.Log(animal);
        }

        // Exercise 7
        {
            if (Mes == 3 && Dia >= 21 || Mes == 2 && Dia <= 19)
            {
                Debug.Log("Aries");
            }
            else if (Mes == 4 && Dia >= 20 || Mes == 5 && Dia <= 20)
            {
                Debug.Log("Tauro");
            }
            else if (Mes == 5 && Dia >= 21 || Mes == 6 && Dia <= 20)
            {
                Debug.Log("Géminis");
            }
            else if (Mes == 6 && Dia >= 21 || Mes == 7 && Dia <= 22)
            {
                Debug.Log("Cáncer");
            }
            else if (Mes == 7 && Dia >= 23 || Mes == 8 && Dia <= 22)
            {
                Debug.Log("Leo");
            }
            else if (Mes == 8 && Dia >= 23 || Mes == 9 && Dia <= 22)
            {
                Debug.Log("Virgo");
            }
            else if (Mes == 9 && Dia >= 23 || Mes == 10 && Dia <= 22)
            {
                Debug.Log("Libra");
            }
            else if (Mes == 10 && Dia >= 23 || Mes == 11 && Dia <= 21)
            {
                Debug.Log("Escorpio");
            }
            else if (Mes == 11 && Dia >= 22 || Mes == 12 && Dia <= 21)
            {
                Debug.Log("Sagitario");
            }
            else if (Mes == 12 && Dia >= 22 || Mes == 1 && Dia <= 19)
            {
                Debug.Log("Capricornio");
            }
            else if (Mes == 1 && Dia >= 20 || Mes == 2 && Dia <= 18)
            {
                Debug.Log("Acuario");
            }
            else if (Mes == 2 && Dia >= 19 || Mes == 8 && Dia <= 20)
            {
                Debug.Log("Leo");
            }
        }

        // Exercise 8
        {
            Centuria = Año / 100;

            if (Centuria == 19)
            {
                Diadificador++;
            }
            else if (Centuria == 18)
            {
                Diadificador += 3;
            }
            else if (Centuria == 17)
            {
                Diadificador += 4;
            }
            else if (Centuria == 15)
            {
                Diadificador += 2;
            }

            while (Año >= 1000)
            {

                Decada = Año - 1000;
                Año -= 1000;
            }
            while (Decada >= 100)
            {
                Decada -= 100;
            }

            resto = Decada/2;
            resto = resto / 2;
            resto = resto%7;

            resto = Decada + resto;
            resto = resto % 7;
            Diadificador += resto;
            

            

            // Comprobador de Mes
            { 
                if (Mes == 1)
                {
                    if (Bisiestificaneitor == true)
                    {
                        Diadificador += 5;
                    }
                    else
                    {
                        Diadificador += 6;
                    }
                }
                else if (Mes == 2)
                {
                    if (Bisiestificaneitor == true)
                    {
                        Diadificador += 1;
                    }
                    else
                    {
                        Diadificador += 2;
                    }
                }
                else if (Mes == 3)
                {
                    Diadificador += 2;
                }
                else if (Mes == 4)
                {
                    Diadificador += 5;
                }
                else if (Mes == 5)
                {
                    Diadificador += 0;
                }
                else if (Mes == 6)
                {
                    Diadificador += 3;
                }
                else if (Mes == 7)
                {
                    Diadificador += 5;
                }
                else if (Mes == 8)
                {
                    Diadificador += 1;
                }
                else if (Mes == 9)
                {
                    Diadificador += 4;
                }
                else if (Mes == 10)
                {
                    Diadificador += 6;
                }
                else if (Mes == 11)
                {
                    Diadificador += 2;
                }
                else if (Mes == 12)
                {
                    Diadificador += 4;
                }

            }

            Diadificador += Dia%7;

            Diadificador = Diadificador%7;

            if (Diadificador == 1)
            {
                Debug.Log("Lunes");
            }
            else if ( Diadificador == 2)
            {
                Debug.Log("Martes");
            }
            else if (Diadificador == 3)
            {
                Debug.Log("Miercoles");
            }
            else if (Diadificador == 4)
            {
                Debug.Log("Jueves");
            }
            else if (Diadificador == 5)
            {
                Debug.Log("Viernes");
            }
            else if (Diadificador == 6)
            {
                Debug.Log("Sabado");
            }
            else if (Diadificador == 0)
            {
                Debug.Log("Domingo");
            }

            // Hecho por Héctor Fernández y David Llabrés

        }

        // Exercise 9
        {
            if (age >= 65)
            {
                if (rank == "gold")
                {
                    Debug.Log("75% of discount");
                }
                else if (rank == "silver")
                {
                    Debug.Log("50% of discount");
                }
                else if (rank == "bronze")
                {
                    Debug.Log("25% of discount");
                }
                else 
                {
                    Debug.Log("0% of discount");
                }
            }
            else if (age >= 18 && age <= 64)
            {
                if (rank == "gold")
                {
                    Debug.Log("50% of discount");
                }
                else if (rank == "silver")
                {
                    Debug.Log("25% of discount");
                }
                else if (rank == "bronze")
                {
                    Debug.Log("10% of discount");
                }
                else 
                {
                    Debug.Log("0% of discount");
                }
            }
            else
            {
                Debug.Log("You cannot be a member of the store and thereforedo not receive any discount");
            }
        }
        // Exercise 10

        if (angle1 + angle2 + angle3 == 180)
        {
            Debug.Log("It can be a triangle");
        }
        else 
        {
            Debug.Log("It can't be a triangle");
        }
    }

    // Update is called once per frame
    
}
