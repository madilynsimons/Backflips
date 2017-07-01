using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public string title;

    public Character()
    {
        title = null;
    }

    public Character(string title)
    {
        this.title = title;
    }
}
