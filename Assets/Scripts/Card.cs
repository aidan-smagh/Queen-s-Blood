using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class Card : MonoBehaviour
{
    public bool hasBeenPlayed;
    public int handIndex;
    private GameManager gm;
    public int power;
    public int pawnsNeeded;

    private void OnMouseDown() {
        if (hasBeenPlayed == false) {
            transform.position += Vector3.up * 5;
            hasBeenPlayed = true;
            gm.availableCardSlots[handIndex] = true;
            Invoke("MoveToDiscardPile", 2f);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void MoveToDiscardPile() {
        gm.discardPile.Add(this);
        gameObject.SetActive(false);
    }
}
