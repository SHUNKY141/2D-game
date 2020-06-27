using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            int numb = SceneManager.GetActiveScene().buildIndex;
            if (numb == 1) SceneManager.LoadScene(2);
            else SceneManager.LoadScene(0);
        }
    }
}