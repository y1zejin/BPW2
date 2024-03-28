using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMouse : MonoBehaviour
{
    public bool cursorVisible;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = cursorVisible;
    }
}
