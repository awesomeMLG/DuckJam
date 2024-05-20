using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CasinoSlots : MonoBehaviour
{
    private Sprite[] symbols;

    private Image[] reels;

    private bool isSpinning;

    private int[] resultsHeld;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If the reels are spinning, simulate spinning animation
        if (isSpinning)
        {
            for (int i = 0; i < reels.Length; i++)
            {
                // Generate random index for the symbol
                int randomIndex = Random.Range(0, symbols.Length);

                // Display the symbol
                reels[i].sprite = symbols[randomIndex];

                // Store the result index
                resultsHeld[i] = randomIndex;
            }

            // Stop spinning after a short delay (you can adjust the delay duration)
            Invoke("StopSpinning", 2f);
        }
    }
}