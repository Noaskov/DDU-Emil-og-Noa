using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject Player;
    public Transform[] Playerspawns;
    public bool firstPlayer = true;
   [SerializeField] private int NumberOfPlayers = 0;

    private void Start()
    {




        if (PhotonNetwork.IsMasterClient)
        {

         PhotonNetwork.Instantiate(Player.name, Playerspawns[0].position, Quaternion.identity);
        }
        else
        {
            PhotonNetwork.Instantiate(Player.name, Playerspawns[1].position, Quaternion.identity);

        }

           


  
          
        
        
    }

    
}
