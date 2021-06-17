using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneOnClick(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
