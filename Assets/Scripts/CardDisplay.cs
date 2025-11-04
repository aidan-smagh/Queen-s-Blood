using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card cardData;
    public Image artworkImage;

    public void Setup(Card data)
    {
        if (data.cardImage != null)
        {
            artworkImage.sprite = data.cardImage;
        }
        else
            Debug.LogError("sprite error");
    }
}
