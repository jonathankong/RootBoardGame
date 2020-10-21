using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Backbone of warriors
public abstract class WarriorController : MonoBehaviour
{
    protected BaseFaction faction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObjectEnums.FactionName GetFactionName()
    {
        return faction.GetFactionName();
    }
}
