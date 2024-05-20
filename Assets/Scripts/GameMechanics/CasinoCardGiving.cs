using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CasinoCardGiving : MonoBehaviour
{
    [SerializeField] private int numCardsToGive;

    [SerializeField] private Text[] cardTextElements;

    private string[] presetTypes = { "The Sun", "The Moon" };

    private string[] unlockableTypes = { "The Fool", "The Magician", "The Hanged Man", "The Hierophant", "The Reverse", "The Clock", "The Ace of Spades", "The Credit Card", "Death's ID"};

    private Sprite[] presetTypeSprites;

    private Image[] presetTypeImages;

    private Sprite[] unlockableTypeSprites;

    private Image[] unlockableTypeImages;
    
    private int[] presetCardsGiven;

    private int[] unlockableCardsGiven;

    private bool isCardDrawn;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (presetTypeSprites.Length != presetTypeImages.Length)
        {
            Debug.Log("Additional preset cards have been found. Only Sun and Moon cards are preset.");
            return;
        }
    }

    

    private void CardRandomizer()
    {
        Shuffle(unlockableTypeSprites);

        for (int i = 0; i < 2; i++)
        {
            unlockableTypeImages[i].sprite = unlockableTypeSprites[i];
        }
    }

    private void Shuffle<T>(T[] array)
    {
        int n = array.Length;
        while (n > 1)
        {
            int k = Random.Range(0, n--);
            (array[n], array[k]) = (array[k], array[n]);
        }
    }
}
