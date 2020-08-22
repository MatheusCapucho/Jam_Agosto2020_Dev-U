using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelection : MonoBehaviour
{

    public static int capuchoIndex = 0;
    public static int cavalcaIndex = 0;
    public static int ikaroIndex = 0;
    public static int flavioIndex = 0;


    public int playerIndex = 1;
    public static int maxPlayers;
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
        
        capuchoIndex = playerIndex;
        if (playerIndex == maxPlayers)
        {
            StartGame();
        }
        playerIndex++;
    }
    public void ChooseCavalca()
    {     
        cavalcaIndex = playerIndex;
        if (playerIndex == maxPlayers)
        {
            StartGame();
        }
        playerIndex++;
    }
    public void ChooseIkaro()
    {   
        ikaroIndex = playerIndex;
        if (playerIndex == maxPlayers)
        {
            StartGame();
        }
        playerIndex++;
    }
    public void ChooseFlavio()
    {
        flavioIndex = playerIndex;
        if (playerIndex == maxPlayers)
        {
            StartGame();
        }
        playerIndex++;
    }

    public void StartGame()
    {
        DontDestroyOnLoad(playerSelectionManager);
        SceneManager.LoadScene("Capucho"); // colocar aqui o nome da cena do game
        playerIndex--;
    }
}
