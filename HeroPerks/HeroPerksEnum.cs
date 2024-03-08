using System;

namespace HeroPerks.Enum
{
    [Flags]
    public enum HeroPerksEnum
    {
        WaterBreathing = 1 << 0,
        Stealth = 1 << 1,
        AutoHeal = 1 << 2,
        DoubleJump = 1 << 3
    }
}