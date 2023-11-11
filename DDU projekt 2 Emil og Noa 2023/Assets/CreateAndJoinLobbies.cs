using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;



public class CreateAndJoinLobbies : MonoBehaviourPunCallbacks
{
    public TMP_InputField createInput;
    public TMP_InputField joinInput;
    public GameObject MainPanel;
    public GameObject MapTree;
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInput.text);

    }
     
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom()
    {
        MainPanel.SetActive(false);
        MapTree.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
