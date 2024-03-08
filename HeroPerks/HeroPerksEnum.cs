using System;

namespace HeroPerks.Enum
{
    [Flags]
    public enum HeroPerksEnum
    {
        Stealth = 1 << 0,
        DoubleJump = 1 << 1,
        WaterBreathing = 1 << 2,
        AutoHeal = 1 << 3
    }
}