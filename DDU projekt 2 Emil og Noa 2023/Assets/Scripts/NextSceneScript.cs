using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneScript : MonoBehaviour
{
   public void NextScenePls()
    {
        SceneManager.LoadScene(3);
    }
}
