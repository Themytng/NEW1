using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public GameObject hp1;
    public GameObject hp2;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 2;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage (int amount)
    {
        currentHealth -= amount;

        if(currentHealth == 2)
        {
            hp2.SetActive(false);
        }

        if (currentHealth == 1)
        {
            hp1.SetActive(false);
        }

        if(currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
