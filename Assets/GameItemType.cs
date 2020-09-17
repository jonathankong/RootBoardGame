using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItemType : MonoBehaviour
{
    private static GameItemType gameItemType = null;

    private enum _GameItemType
    {
        Clearing
    }

    private GameItemType() { }

    public static GameItemType getInstance()
    {
        if (gameItemType == null)
        {
            gameItemType = new GameItemType();
        }
        return gameItemType;
    }
}
