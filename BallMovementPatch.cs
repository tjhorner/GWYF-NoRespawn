using Harmony;

namespace NoRespawn
{
    [HarmonyPatch(typeof(BallMovement), "ResetToLastShot")]
    public class BallMovementPatch
    {
        public static bool Prefix(BallMovement __instance)
        {
            __instance.outOfBounds = false;
            __instance.m_isShotReadyToStart = true;
            __instance.m_ballIsNotMoving = true;
            return false;
        }
    }
}
