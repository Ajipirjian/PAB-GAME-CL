using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public GameObject[] Cube;
    public int clectedcube;

    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        isGameOver = false;
        clectedcube = 0;
    }

    // Update is called once per frame
    void Update()
    {
      
        if (clectedcube == Cube.Length)
        {
            GameOver();
        }
    }
    void GameOver()
    {
        isGameOver = true;
        panel.SetActive(true);
        foreach ( var cube in Cube)
        {
            cube.SetActive(false);
        }
    }

    public void Displaycube()
    {
        for(int i = 0; i < clectedcube; i++)
        {
            Cube[i].GetComponent<Image>().color = Color.yellow;
        }
    }

}
