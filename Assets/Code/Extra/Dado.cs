using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Dado : MonoBehaviour
{

    /*1,2,3*/
    private int resultado; private string comprobar;
    /*4*/
    private int nota;
    /*5*/
    private float precio;
    private float descuento;
    private float precio_final;
    /*6*/
    private int lado1;
    private int lado2;
    private int lado3;
    /*7,8,9*/
    private string letra;
    /*10,11,12, 14*/
    [SerializeField] private int dia;
    [SerializeField] private int mes;
    [SerializeField] private int año = 2023;
    private bool Bisiestificaneitor;
    private int diaspasados;
    private int edad;
    [SerializeField] private int diaNacimiento;
    [SerializeField] private int mesNacimiento;
    [SerializeField] private int añoNacimiento;
    /*13*/
    [SerializeField] private float alto;
    [SerializeField] private float largo;
    private float area;
    /*15*/
    [SerializeField] private float Nº1;
    [SerializeField] private float Nº2;
    [SerializeField] private string Operacion;
    private float Resultado15;

    /*16*/
    private int[] Enteros;
    /*26*/
    private int One2Ten = 1;
    /*27*/
    private int countback = 15;
    // Start is called before the first frame update
    /*28*/
    [SerializeField] private int factorial;
    private int factor;
    private int resultadofactorial;
    /*29*/
    [SerializeField] private int TablaX;
    private int diez = 10;
    private int tabla;
    /*30*/
    [SerializeField] private int iteracion;
    private int asteriscos;

    void Start()
    {

        //Actividad 1,2,3
        {
            resultado = 0;

            if (resultado >= 1)
            {
                comprobar = "el resultado es positivo";
            }
            if (resultado < 0)
            {
                comprobar = "el resultado es negativo";
            }
            else
            {
                comprobar = "el resultado es 0";
            }

            Debug.Log(comprobar);
        }

        // Actividad 4
        {
            nota = 0;

            if (nota >= 9)
            {
                Debug.Log("Excelente");
            }
            if (nota >= 7 && nota <= 8)
            {
                Debug.Log("Notable");
            }
            if (nota >= 5 && nota <= 6)
            {
                Debug.Log("Suficiente");
            }
            else
            {
                Debug.Log("Insuficiente");
            }
        }

        // Actividad 5
        {
            precio = 100;
            descuento = 10;

            precio_final = (precio - (precio / descuento));
            Debug.Log(precio_final + "€");
        }

        //Actividad 6 
        {

            lado1 = 1;
            lado2 = 2;
            lado3 = 2;

            if (lado1 == lado2 && lado1 == 3)
            {
                Debug.Log("Equilatero");
            }
            if (lado1 == lado2 && lado1 != lado3 || lado2 == lado3 && lado1 != lado2 || lado1 == lado3 && lado1 != lado2)
            {
                Debug.Log("Isosceles");
            }
            else
            {
                Debug.Log("Escaleno");
            }
        }

        //Actividad 7,8,9
        {
            if (letra != "a" || letra != "e" || letra != "i" || letra != "o" || letra != "u")
            {
                Debug.Log("Consonante");
            }
            else
            {
                Debug.Log("Vocal");
            }
        }

        //Actividad 10,11,12 (Ha arreglar)
        {
            //Bisiestificaneitor
            if (año % 4 == 0 && año % 100 == 0 && año % 400 == 0 || año % 4 == 0 && año % 100 != 0)
            {
                Bisiestificaneitor = true;
            }
            else
            {
                Bisiestificaneitor = false;
            }

            diaspasados = (((mes - 1) * 30)) + dia;
            Debug.Log(diaspasados);
            if (Bisiestificaneitor == true)
            {
                diaspasados--;
            }
            if (Bisiestificaneitor == false && mes >= 3)
            {
                diaspasados--;
                diaspasados--;
            }

            // 31Inador (no usar es una abominacion de la programacion) (Unfinished)
            /*{
                if (mes >= 12 && dia == 31)
                {
                    diaspasados += 7;
                }
                else if (mes >= 10 && mes <= 11)
                {
                    if (mes == 10 && dia == 31 || mes == 11)
                    {
                        diaspasados += 6;
                    }
                    else
                    {
                        diaspasados += 5;
                    }
                }
                else if (mes >= 8 && mes <= 9)
                {
                    diaspasados += 5;
                }
                else if (mes == 7)
                {
                    diaspasados += 4;
                }
                else if (mes >= 5 && mes <= 6)
                {
                    diaspasados += 3;
                }
                else if (mes >= 3 && mes <= 4)
                {
                    diaspasados += 2;
                }
                else if (mes == 2)
                {
                    diaspasados += 1;
                }
                else if (mes == 1 && dia == 31)
                {
                    diaspasados += 1;
                }
                else { diaspasados += 0; }


            }*/

            Debug.Log(diaspasados);
        }

        // Actividad 13
        {
            area = alto * largo;
            Debug.Log(area);
        }

        // Actividad 14
        {
            edad = año - añoNacimiento - 1;
            if (mesNacimiento >= mes)
            {
                if (mesNacimiento == mes)
                {
                    if (diaNacimiento >= dia)
                    {
                        edad += 1;
                    }
                }
            }
            Debug.Log(edad);
        }

        // Activdad 15
        {
            if (Operacion == "+" || Operacion == "addition")
            {
                Resultado15 = Nº1 + Nº2;
            }
            else if (Operacion == "-" || Operacion == "subtraction")
            {
                Resultado15 = Nº1 - Nº2;
            }
            else if (Operacion == "x" || Operacion == "*" || Operacion == "product")
            {
                Resultado15 = Nº1 * Nº2;
            }
            else if (Operacion == "/" || Operacion == "%" || Operacion == "division")
            {
                Resultado15 = Nº1 / Nº2;
            }

            Debug.Log (Resultado15);
        }

        // Actividad 16

        // Actividad 26
        {
            while (One2Ten >= 10)
            {
                Debug.Log(One2Ten);
                One2Ten++;
            }
        }
        // Actividad 27
        {
            while (countback <= 15 && countback >= 0)
            {
                Debug.Log(countback);
                countback--;
            }
        }
        // Actividad 28
        {
            factor = factorial;
            while (factor <= factorial && factor >= 1)
            {
                resultadofactorial += factorial * factor;
                factor--;
            }

            Debug.Log(resultadofactorial);
        }
        // Actividad 29
        {
            while (diez >= 0)
            {
                tabla = diez * TablaX;
                diez--;
                Debug.Log(tabla);
            }
        }
        // Actividad 30
        {
           //String
        }
    }
    
    
    }


   
