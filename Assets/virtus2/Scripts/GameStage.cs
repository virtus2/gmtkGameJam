using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStage : MonoBehaviour
{
    public WorldTilemap[] Stages;

    private void Start()
    {
        Stages = GetComponentsInChildren<WorldTilemap>();
        Debug.Log(Stages.Length);

    }
    public void NextStage()
    { 

    }
}