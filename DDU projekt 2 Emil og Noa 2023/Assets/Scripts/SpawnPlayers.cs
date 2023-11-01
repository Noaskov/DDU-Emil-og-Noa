using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject Player1;
    public Transform PlayerSpawn1;
    

    private void Start()
    {
       
             PhotonNetwork.Instantiate(Player1.name, PlayerSpawn1.position , Quaternion.identity);
          
        
        
    }
}
