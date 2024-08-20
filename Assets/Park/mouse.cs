using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    private void OnValidate()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
