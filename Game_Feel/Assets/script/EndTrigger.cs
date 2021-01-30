using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    void OnTriggerEnter()
    {
        Debug.Log("hello");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
