using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepAudioAlive : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
