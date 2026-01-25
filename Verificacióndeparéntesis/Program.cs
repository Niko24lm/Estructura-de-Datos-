
using System;
using System.Collections.Generic;

class BalanceoParentesis
{
    /// <summary>
    /// Verifica si los paréntesis, llaves y corchetes están balanceados
    /// </summary>
    /// <param name="expresion">Expresión matemática a evaluar</param>
    /// <returns>true si está balanceada, false en caso contrario</returns>
    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            // Si es símbolo de apertura, se apila
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Si es símbolo de cierre, se verifica
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0)
                    return false;

                char tope = pila.Pop();

                if (!EsParCorrecto(tope, c))
                    return false;
            }
        }

        // Si la pila está vacía, está balanceada
        return pila.Count == 0;
    }

    /// <summary>
    /// Verifica si los símbolos son un par correcto
    /// </summary>
    static bool EsParCorrecto(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }

    static void Main()
    {
        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";

        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }
}

