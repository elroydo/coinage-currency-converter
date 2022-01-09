using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

    public void RestartScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }
}
