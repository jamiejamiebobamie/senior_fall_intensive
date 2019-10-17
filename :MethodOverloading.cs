using UnityEngine;
using System.Collections;

public class MethodOverloading : MonoBehaviour
{

    /* method overloading is all about calling your
     * methods by the same name and then having
     * C# determine which to use by lookijng at
     * the variable signature and the
     * parameters you pass in
     */

    public int Add(int num1, int num2)
	{
		return num1 + num2;
	}

	public string Add(string num1, string num2)
	{
		return num1 + num2;
	}
}
