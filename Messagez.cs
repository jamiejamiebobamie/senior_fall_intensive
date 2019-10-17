using UnityEngine;
using System.Collections;

public class Messagez
{
	private string message;

    // fields in a class:
    public string Message
	{
        get
		{
			return message;
		}
        set
		{
			message = value;
		}
	}

    public string Aside { get; set; }
}
