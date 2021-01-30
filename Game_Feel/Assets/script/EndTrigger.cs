﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    void OnTriggerEnter()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
