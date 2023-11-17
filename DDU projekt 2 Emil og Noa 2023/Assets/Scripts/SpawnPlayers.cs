using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject[] Players;
    public Transform[] Playerspawns;
    public bool firstPlayer = true;
   [SerializeField] private int NumberOfPlayers = 0;


        
    private void Start()
    {



        if (PhotonNetwork.IsMasterClient)
        {

         PhotonNetwork.Instantiate(Players[0].name, Playerspawns[0].position, Quaternion.identity);
           
        }
        else if(!PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.Instantiate(Players[1].name, Playerspawns[1].position, Quaternion.identity);
           
            
            
        }
        

        

           


  
          
        
        
    }

    public void resetPlayers()
    {
        var player1 = GameObject.Find("Player1(Clone)");
        player1.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        player1.transform.position = Playerspawns[0].position;

        var player2 = GameObject.Find("Player2(Clone)");
        player2.GetComponent<Rigidbody2D>().velocity = new Vector3(0,0,0);
        player2.transform.position = Playerspawns[1].position;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            resetPlayers();
        }
    }


}
