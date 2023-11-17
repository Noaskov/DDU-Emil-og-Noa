using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class MapSelector : MonoBehaviour
{
    
    
    public void Map1Selected()
    {
        if(PhotonNetwork.IsMasterClient)
        SceneManager.LoadScene("First map");
    }
    public void Map2Selected()
    {
        if (PhotonNetwork.IsMasterClient)
            SceneManager.LoadScene("Secound Map");
    }
    public void Map3Selected()
    {
        if (PhotonNetwork.IsMasterClient)
            SceneManager.LoadScene("Third map");
    }
    public void Map4Selected()
    {

    }
}
