using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

/*1,2,3 
1. Comprueba si un número dado es positivo
2. Comprueba si un número dado es negativo
3. Combina los ejercicios 1 y 2 para dado un número, determinar si es positivo, es negativo o es 0
 */


/*4 
Dada una nota de un examen, determina si se trata de un Suspenso, Aprobado, Notable o
Excelente. Considera Suspenso una nota menor a 5; Aprobado una nota mayor o igual a 5,
pero menor a 7; Notable una nota mayor o igual a 7, pero menor a 9; y Excelente, una nota
mayor o igual a 9
*/

/*5
5. Dados un precio y un descuento, calcula el precio final. Por ejemplo, si el precio es 100 y el
descuento es del 10%, entonces como precio final deberías obtener 90€
 */

/*6
 6. Clasifica triángulos: dada la medida de los 3 lados, tienes que determinar si se trata de un
triángulo equilátero (todos los lados iguales), un triángulo isósceles (solo dos de los lados son
iguales) o un triángulo escaleno (todos los lados son diferentes)
 */

/*7,8,9
 7. Dada una letra, determina si se trata de una vocal
8. Dada una letra, determina si se trata de una consonante
9. Combina los ejercicios 7 y 8 para determinar si una letra es una vocal o una consonante
 */

/*10
 * Dada una fecha (día y mes), calcula cuántos días han pasado desde el inicio del año. No hace
falta que tengas en cuenta si el año es bisiesto. Supón que trabajas sobre un año no bisiesto,
que en total tiene 365 días
Dado un año, determina si se trata de un año bisiesto. Un año bisiesto es aquel que es
múltiplo de 4. Eso sí, si es múltiplo de 4 y múltiplo de 100, también tiene que ser múltiplo de
400 para ser bisiesto:
๏ El año 8 es bisiesto porque es múltiplo de 4 y no de 100
๏ El año 200 no es bisiesto porque es múltiplo de 4 y de 100, pero no de 400
๏ El año 800 es bisiesto porque es múltiplo de 4, de 100 y de 400
12. Combina los ejercicios 10 y 11 para que ahora, dada una fecha (día, mes y año) determines
cuántos días han pasado desde el inicio del año. En este ejercicio sí que debes tener en
cuenta si se trata de un año bisiesto o no
*/

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
    /*10,11,12*/
    [SerializeField] private int mes;
    [SerializeField] private int dia;
    [SerializeField] private int año;
    private bool Bisiestificaneitor;
    private int diaspasados;
    // Start is called before the first frame update
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
        //Actividad 10,11,12
        {
            //Bisiestificaneitor
            if (año %4 == 0 && año %100 == 0 && año %400 == 0 || año %4 == 0 && año %100 != 0)
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

            // 31inador (no usar es una abominacion de la tecnologia)
            /*{
                if (mes >= 12)
                {
                    diaspasados += 7;
                }
                if (mes >= 10 && mes <= 11)
                {
                    diaspasados += 6;
                }
                if (mes >= 8 && mes <= 9)
                {
                    diaspasados += 5;
                }
                if (mes == 7)
                {
                    diaspasados += 4;
                }
                if (mes >= 5 && mes <= 6)
                {
                    diaspasados += 3;
                }
                if (mes >= 3 && mes <= 4)
                {
                    diaspasados += 2;
                }
                if (mes == 2)
                {
                    diaspasados += 1;
                }
                if (mes == 1 && dia == 31)
                {
                    diaspasados+= 1;
                }*/
            }
            Debug.Log(diaspasados);
        }
    }
}

   
