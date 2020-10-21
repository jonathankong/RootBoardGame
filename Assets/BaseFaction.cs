using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Backbone of factions
public abstract class BaseFaction : IFaction
{
    protected GameObjectEnums.FactionName factionName;

    public BaseFaction(GameObjectEnums.FactionName factionName)
    {
        SetFactionName(factionName);
    }

    private void SetFactionName(GameObjectEnums.FactionName factionName)
    {
        this.factionName = factionName;
    }
    public GameObjectEnums.FactionName GetFactionName()
    {
        return factionName;
    }
}
