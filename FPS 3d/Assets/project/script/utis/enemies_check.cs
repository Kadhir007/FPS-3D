using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemies_check : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform bots;
    private void Start()
    {
        bots = GetComponent<Transform>();
    }

    private void Update()
    {
        if (bots.childCount <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("pass");

        }
    }
}
