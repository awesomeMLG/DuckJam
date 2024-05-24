using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UIElements;

public class CasinoDice : MonoBehaviour
{
    [SerializeField] private int[] numDiceRolled;

    private bool isRolling;

    private GameObject[] dice;

    [SerializeField] private int minDotCount;

    [SerializeField] private int maxDotCount;

    private int results;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RollDice();
    }

    private void RollDice()
    {
        int totalDotCount = Random.Range(minDotCount, maxDotCount);
        if (isRolling)
        {
            totalDotCount = results;
            print(results);
        }

        else
        {
            return;
        }
    }
}
