using UnityEngine;
using System.Collections.Generic;

public class CardManager : MonoBehaviour
{
    public GameObject cardPrefab;
    public Transform cardParent;

    void Start()
    {
        Card[] loadedCards = Resources.LoadAll<Card>("Cards");
        int i = 0;
        foreach (Card c in loadedCards)
        {
            GameObject newCard = Instantiate(cardPrefab, cardParent);
            newCard.GetComponent<CardDisplay>().Setup(c);
            i++;
        }
    }
}
