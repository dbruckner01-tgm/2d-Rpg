using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : CharacterClass
{
    //Inheritance Structure: Priest/Mage->MagicUser->PlayerClass->CharacterClass
    //Playerclass is empty for now but will store some Items or other features such as the Partylist as well as some stats of the party
    //Will be important for the transition between Battles and the world
    //I know it's in english. Should be in german cuz consistency
    public override void initialize()
    {
        base.initialize();
    }

    public override void levelUp()
    {
        base.levelUp();
    }
    public void fillMP()
    {
        this.n_MP = this.n_maxMP;
    }
}
