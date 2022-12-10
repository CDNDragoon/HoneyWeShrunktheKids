using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class GameState : MonoBehaviour
{
    [SerializeField]
    private GameObject deathScreenCanvas;

    [SerializeField]
    private GameObject monster;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject playerLocomotionSystem;

    [SerializeField]
    private Volume globalVolume;

    [SerializeField]
    private AudioSource deathSound;

    private CanvasGroup canvasGroup;
    private bool dead;

    void Start()
    {
        canvasGroup = deathScreenCanvas.GetComponent<CanvasGroup>();
        dead = false;
    }

    public void RestartGame()
    {
        // TODO: when restarting, fade screen out and back in
        Debug.Log("Restarting game");
        SceneManager.LoadScene("MainCave");
    }

    IEnumerator FadeInDeathScreen()
    {
        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime * 0.5f;
            yield return null;
        }
    }

    IEnumerator FadeInVolume()
    {
        while (globalVolume.weight < 1)
        {
            globalVolume.weight += Time.deltaTime * 0.5f;
            yield return null;
        }
    }

    public void KillPlayer()
    {
        if (dead) return;

        Debug.Log("Player has been killed");
        dead = true;

        // Turn off monster movement and audio
        var monsterMovementScript = monster.GetComponent<MonsterMovement>();
        if (monsterMovementScript != null) monsterMovementScript.enabled = false;

        var monsterAudio = monster.GetComponent<AudioSource>();
        if (monsterAudio != null) monsterAudio.enabled = false;

        // Turn off player movement
        var playerMovement = player.GetComponent<FirstPersonMovement>();
        if (playerMovement != null) playerMovement.enabled = false;
        playerLocomotionSystem.SetActive(false);

        // TODO: slow down time?
        // Time.timeScale = 0;

        // Play death sound
        deathSound.Play();

        // Show death overlay
        deathScreenCanvas.SetActive(true);
        StartCoroutine(FadeInDeathScreen());
        StartCoroutine(FadeInVolume());
    }
}
