using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public int capucho, cavalca, ikaro, flavio;
    public int moveValue, currentPlayer;

    private void Start()
    {
        SetGame();
    }

    public void SetGame()
    {
        for (int i = 1; i <= PlayerSelection.maxPlayers; i++)
        {
            if (PlayerSelection.capuchoIndex == i)
            {
                capucho = i;
            }
            if (PlayerSelection.cavalcaIndex == i)
            {
                cavalca = i;
            }
            if (PlayerSelection.ikaroIndex == i)
            {
                ikaro = i;
            }
            if (PlayerSelection.flavioIndex == i)
            {
                flavio = i;
            }
        }
        StartGame();
    }
    private void StartGame()
    {
        currentPlayer = 1;
    }

    public void RightAnswer()
    {
        moveValue = 5;
        Move();
    }
    public void WrongAnswer()
    {
        moveValue = 2;
        Move();
    }

    public void Move()
    {
        //logica de movimentação

        NextPlayer();
    }

    public void NextPlayer()
    {
        if (currentPlayer < PlayerSelection.maxPlayers)
        {
            currentPlayer++;
        }
        else
        {
            currentPlayer = 1;
        }

    }
}
