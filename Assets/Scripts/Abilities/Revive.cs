using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Revive : AbilityClass
{
    public Revive()
    {
        this.n_lvl = 1;
        this.n_lvlReq = 2;
        this.s_name = "Revive";
        this.s_description = "";
        this.n_uses = 0; //Check after combat if this is a multiple of 5
    }
    public override bool action(ref CharacterClass user, ref MonsterClass target)
    {
        if (user.drainMP(10))
        {
            target.revive(this.n_lvl * 0.1);
            this.n_uses++;
            return true;
        } else
        {
            return false;
        }
            
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
