using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{

    public string cardName;
    public int points;
    public int pawnsNeeded;
    public int spaceOccupied;
    public int spaceForward;
    public Texture2D cardImage;
}
