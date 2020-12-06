using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject m_LooseMenu;
    public GameObject m_VictoryMenu;
    public GameObject m_PauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        m_PauseMenu.SetActive(true);
    }

    public void Resume()
    {
        m_PauseMenu.SetActive(false);
    }

    public void Victory()
    {
        m_VictoryMenu.SetActive(true);
    }

    public void Menu()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }
}
