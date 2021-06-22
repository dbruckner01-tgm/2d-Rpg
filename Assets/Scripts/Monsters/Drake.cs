using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drake : MonoBehaviour
{
    public override void initialize(int lvl)
    {
        base.initialize(lvl);
        this.s_name = "Drake";
        this.n_maxHP = (int)Math.Ceiling((double)(n_maxHP * 2));
        this.n_stdStrength = (int)Math.Ceiling((double)(n_stdStrength * 0.5));
        this.resetStats();
    }
}
