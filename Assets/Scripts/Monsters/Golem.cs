using System;

public class Golem : MonsterClass
{
    public Golem(int lvlUP) : base(lvlUP)
    {
        this.n_expDrop = 500;
        this.s_name = "Golem";
        this.n_maxHP = (int)Math.Ceiling((double)(this.n_maxHP * 6));
        this.n_maxMP = (int)Math.Ceiling((double)(this.n_maxMP * 1));
        this.n_stdStrength = (int)Math.Ceiling((double)(this.n_stdStrength * 3));
        this.n_stdAgility = (int)Math.Ceiling((double)(this.n_stdAgility * 0.8));
        this.n_stdVitality = (int)Math.Ceiling((double)(this.n_stdVitality * 3));
        this.n_stdMagicalMight = (int)Math.Ceiling((double)(this.n_stdMagicalMight * 1));
        this.n_stdMagicalResistance = (int)Math.Ceiling((double)(this.n_stdMagicalResistance * 1.1));
        this.resetStats();
    }
    public override void initialize(int lvl)
    {
        base.initialize(lvl);
        this.s_name = "Golem";
        this.n_maxHP = (int)Math.Ceiling((double)(this.n_maxHP * 6));
        this.n_maxMP = (int)Math.Ceiling((double)(this.n_maxMP * 1));
        this.n_stdStrength = (int)Math.Ceiling((double)(this.n_stdStrength * 3));
        this.n_stdAgility = (int)Math.Ceiling((double)(this.n_stdAgility * 0.8));
        this.n_stdVitality = (int)Math.Ceiling((double)(this.n_stdVitality * 3));
        this.n_stdMagicalMight = (int)Math.Ceiling((double)(this.n_stdMagicalMight * 1));
        this.n_stdMagicalResistance = (int)Math.Ceiling((double)(this.n_stdMagicalResistance * 1.1));
        this.resetStats();
    }
}
