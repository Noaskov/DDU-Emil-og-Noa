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

        var HostPlayer = PhotonNetwork.Instantiate(Player.name, Playerspawns[0].position, Quaternion.identity);
            HostPlayer.name = "HostPlayer";
        }
        else if(!PhotonNetwork.IsMasterClient)
        {
            var TheOtherPlayer = PhotonNetwork.Instantiate(Player.name, Playerspawns[1].position, Quaternion.identity);
           
            TheOtherPlayer.name = "ClientPlayer";
            
        }
        

        

           


  
          
        
        
    }

    public void resetPlayers()
    {
        if(GameObject.Find("HostPlayer") != null)
        {

            Transform Player1 = GameObject.Find("HostPlayer").transform;
            Rigidbody2D rb1 = Player1.GetComponent<Rigidbody2D>();
            rb1.velocity = new Vector3(0, 0, 0);
            Player1.transform.position = Playerspawns[0].position;
            Transform Player2 = GameObject.Find("Player(Clone)").transform;
            Rigidbody2D rb2 = Player2.GetComponent<Rigidbody2D>();
            rb2.velocity = new Vector3(0, 0, 0);
            Player2.transform.position = Playerspawns[1].position;
        } else
        {
            Transform Player1 = GameObject.Find("ClientPlayer").transform;
            Rigidbody2D rb1 = Player1.GetComponent<Rigidbody2D>();
            rb1.velocity = new Vector3(0, 0, 0);
            Player1.transform.position = Playerspawns[1].position;
            Transform Player2 = GameObject.Find("Player(Clone)").transform;
            Rigidbody2D rb2 = Player2.GetComponent<Rigidbody2D>();
            rb2.velocity = new Vector3(0, 0, 0);
            Player2.transform.position = Playerspawns[0].position;
        }

        
        
           

        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            resetPlayers();
        }
    }


}
