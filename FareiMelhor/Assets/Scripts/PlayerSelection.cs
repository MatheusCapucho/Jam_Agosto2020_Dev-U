using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelection : MonoBehaviour
{
    public struct Detectives
{
    public bool ativo;
    public int index;
};

    Detectives capucho, ikaro, cavalca, flavio;

    
    public int playerIndex = 1;
    public int maxPlayers;
    public GameObject playerSelectionManager;


    public void TwoPlayers()
    {
        maxPlayers = 2;
    }
    public void ThreePlayers()
    {
        maxPlayers = 3;
    }
    public void FourPlayers()
    {
        maxPlayers = 4;
    }

    public void ChooseCapucho()
    {
        capucho.ativo = true;
        capucho.index = playerIndex;
        if (playerIndex == maxPlayers)
        {
            StartGame();
        }
        playerIndex++;
    }
    public void ChooseCavalca()
    {
        cavalca.ativo = true;
        cavalca.index = playerIndex;
        if (playerIndex == maxPlayers)
        {
            StartGame();
        }
        playerIndex++;
    }
    public void ChooseIkaro()
    {
        ikaro.ativo = true;
        ikaro.index = playerIndex;
        if (playerIndex == maxPlayers)
        {
            StartGame();
        }
        playerIndex++;
    }
    public void ChooseFlavio()
    {
        flavio.ativo = true;
        flavio.index = playerIndex;
        if (playerIndex == maxPlayers)
        {
            StartGame();
        }
        playerIndex++;
    }

    public void StartGame()
    {
        DontDestroyOnLoad(playerSelectionManager);
        SceneManager.LoadScene("Principal");
    }
}
