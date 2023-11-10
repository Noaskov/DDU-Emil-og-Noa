using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSelector : MonoBehaviour
{
    public void Map1Selected()
    {
        SceneManager.LoadScene("First map");
    }
    public void Map2Selected()
    {
        SceneManager.LoadScene("Secound Map");
    }
    public void Map3Selected()
    {
        SceneManager.LoadScene("Third map");
    }
    public void Map4Selected()
    {

    }
}
