using HutongGames.PlayMaker;

namespace SteelSoulHUD
{
    internal static class PlayMakerExtensions
    {
        internal static FsmState GetState(this PlayMakerFSM fsm, string name)
        {
            return fsm.FsmStates.FirstOrDefault(s => s.Name == name);
        }
    }
}