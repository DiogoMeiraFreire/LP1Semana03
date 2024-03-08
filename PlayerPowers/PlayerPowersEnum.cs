using System;

namespace PlayerPowers.Enum
{
    [Flags]
    public enum PlayerPowersEnum
    {
        Fly = 1 << 0,
        XRayVision = 1 << 1,
        SuperStrength = 1 << 2
    }
}