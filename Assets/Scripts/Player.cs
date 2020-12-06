using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager m_GameManager;

    [SerializeField]
    private int m_Health = 3;


    void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }

        if(m_Health <= 0)
        {
            Die();
        }
    }

    public void Move()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.Q))
        {

        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z))
        {

        }
    }

    public void Attack()
    {

    }

    public void LooseHealth()
    {
        m_Health -= 1;
    }

    public void Die()
    {
        m_GameManager.m_LooseMenu.SetActive(true);
    }

    public void ResetPlayer()
    {
        m_Health = 3;
    }
}
