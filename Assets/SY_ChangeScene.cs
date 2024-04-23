using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SY_ChangeScene : MonoBehaviour
{
    public void changeScene(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
