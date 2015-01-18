﻿using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
	public float restartDelay = 5f;

    Animator anim;
	float restartTime;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");

			restartTime+=Time.deltaTime;

			if(restartTime>=restartDelay)
			{
				Application.LoadLevel(Application.loadedLevel);
			}
        }
    }
}
