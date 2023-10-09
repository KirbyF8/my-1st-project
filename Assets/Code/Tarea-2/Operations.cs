using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
    [SerializeField] private float num;
    [SerializeField] private float num1;
    [SerializeField] private float num2;
    private float resultado;

    void Start()
    {

        resultado = num1 + num2;
        Debug.Log(resultado);
        resultado = num1 - num2;
        Debug.Log(resultado);
        resultado = num1 * num2;
        Debug.Log(resultado);
        resultado = num1 / num2;
        Debug.Log(resultado);

       
        Debug.Log(num1 + num2);
        
        Debug.Log(num1 - num2);
      
        Debug.Log(num1 * num2);
       
        Debug.Log(num1 / num2);


        resultado = num %2;
        Debug.Log(resultado);

        Debug.Log(num %2);

        // Si es par = 0, si es impar 1

        Debug.Log(num % 3);
        // Si es múltiplo de 3 = 0, si no es múltiplo de par y ademas es par = 1 , y si es impar = 2
        Debug.Log(num % 4);
        // Si es múltiplo de 4 = 0, si es par y no es múltiplo de 4 = 2, si es impar es = 1
    }


}
