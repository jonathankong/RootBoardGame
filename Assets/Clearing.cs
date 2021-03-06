﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clearing : MonoBehaviour
{
    [SerializeField]
    PiecesOnClearingDictionary picDict;
    public IDictionary<GameObjectEnums.FactionName, int> PiecesInClearingDictionary
    {
        get { return picDict; }
        set { picDict.CopyFrom(value); }
    }

    private void Awake()
    {
        PiecesInClearingDictionary = new Dictionary<GameObjectEnums.FactionName, int>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<WarriorController>(out WarriorController component))
        {
            GameObjectEnums.FactionName factionName = component.GetFactionName();

            if (!PiecesInClearingDictionary.ContainsKey(factionName))
            {
                PiecesInClearingDictionary.Add(factionName, 1);
            }
            else
            {
                PiecesInClearingDictionary[factionName]++;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.TryGetComponent<WarriorController>(out WarriorController component))
        {
            GameObjectEnums.FactionName factionName = component.GetFactionName();

            if (PiecesInClearingDictionary.ContainsKey(factionName) && PiecesInClearingDictionary[factionName] > 0)
            {
                PiecesInClearingDictionary[factionName]--;
            }

        }
    }
}
