using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlutBanen1 : MonoBehaviour
{

    bool OtherPlayerReady;
    public bool ThisPlayerReady;
    private void OnTriggerStay2D(Collider2D collision)
    {
        ThisPlayerReady = true;
        if (FindObjectOfType<SlutBanen2>().ThisPlayerReady == true)
            if (collision.gameObject.name == "Player2(Clone)")
            {
                var otherPlayer = GameObject.Find("Player2(Clone)");
                otherPlayer.GetComponent<MovementScript>().enabled = false;
                FindObjectOfType<NextSceneScript>().NextScenePls();
            }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ThisPlayerReady = false;
    }
}
