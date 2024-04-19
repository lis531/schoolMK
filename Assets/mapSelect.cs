using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapSelect : MonoBehaviour
{
    public static string mapSelected;

    public void LoadMap(string map)
    {
        Debug.Log(map);
        mapSelected = map;
        SceneManager.LoadScene("Arena");
    }
}
