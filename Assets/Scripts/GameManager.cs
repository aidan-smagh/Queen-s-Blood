using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public List<Card> discardPile = new List<Card>();
    public Transform[] cardSlots;
    public bool[] availableCardSlots = new bool[5];
    
    public Text deckSizeText;
    public Text discardPileText;

    public GameObject cardPrefab;

    public void DrawCard() {
        if (deck.Count >= 1) {
            Card randCard = deck[Random.Range(0, deck.Count)];
        
        for (int i = 0; i < availableCardSlots.Length; i++) {
            if (availableCardSlots[i] == true) {
                randCard.gameObject.SetActive(true);
                randCard.handIndex = i;
                randCard.transform.position = cardSlots[i].position;
                availableCardSlots[i] = false;
                deck.Remove(randCard);
                return;
            }
        }
        }
    }

    public void spawnCard(int index) {
        Vector3 position = new Vector3(index * 2f, -4f, 0);
        GameObject cardGo = Instantiate(cardPrefab, position, Quaternion.identity);
        Card card = cardGo.GetComponent<Card>();

        //cardPower
        //pawnsNeeded
        //spaceTaken
        //effectsIfAny
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deckSizeText.text = deck.Count.ToString();
        discardPileText.text = discardPile.Count.ToString();
    }
}
