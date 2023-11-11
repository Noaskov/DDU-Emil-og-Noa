using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateScript : MonoBehaviour
{

    private PlatformController PC;

    private void Start()
    {
        PC = FindObjectOfType<PlatformController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PC.Activated(1);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PC.Unactivated(0);
    }

}
