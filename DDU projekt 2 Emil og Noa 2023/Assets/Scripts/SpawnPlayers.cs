using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject Player1;
    public Transform[] Playerspawns;
    public bool firstPlayer = true;
    public int NumberOfPlayers = 1;

    private void Start()
    {
        
        
        if (NumberOfPlayers ==1)
        {

             PhotonNetwork.Instantiate(Player1.name, Playerspawns[0].position, Quaternion.identity);
            NumberOfPlayers = 2;
        }
        else if(NumberOfPlayers==2)
        {
            PhotonNetwork.Instantiate(Player1.name, Playerspawns[1].position, Quaternion.identity);
        }
        else
        {
            return;
        }
          
        
        
    }
}
