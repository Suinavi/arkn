using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocks : MonoBehaviour
{
    [Tooltip("Очки за блок")]
    public int points;
    public Gamemanager gamemanager;
    public LevelChanger lc;

    private void Start()
    {
        gamemanager = FindObjectOfType<Gamemanager>();
        lc = FindObjectOfType<LevelChanger>();
        lc.BlockCreated();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        lc.BlockDestroyed();
        gamemanager.AddScore(points);

        Destroy(gameObject);
    }
}
