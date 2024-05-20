using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CasinoCardGiving : MonoBehaviour
{
    [SerializeField] private int numCardsToGive;

    [SerializeField] private Text[] cardTextElements;

    private string[] presetTypes = { "The Sun", "The Moon" };

    private string[] unlockableTypes = { "The Fool", "The Magician", "The Hanged Man", "The Hierophant", "The Reverse", "The Clock", "The Ace of Spades"};

    private int[] cardsGiven;

    private bool isCardDrawn;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CardRandomizer()
    {
        
    }
}
