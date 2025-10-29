using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class GameManager : MonoBehaviour
{
    int playerTurn; //will be 0 for me, 1 for the bot
    int myPoints;
    int botPoints;

    //instantiate player
    Player player;
    Card[] playerHand;
    void Start()
    {
        //draw 5 cards from the deck for me.
        Card[] playerDeck = player.GetDeck();
        
        for (int i = 0; i < 5; i++)
        {
            int randomNum = Random.Range(0, playerDeck.Length);
            playerHand[i] = playerDeck[randomNum];
        }
    }
}