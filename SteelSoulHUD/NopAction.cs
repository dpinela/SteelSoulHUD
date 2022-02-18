using HutongGames.PlayMaker;

namespace SteelSoulHUD
{
    internal class NopAction : FsmStateAction
    {
        public NopAction()
        {
        }

        public override void OnEnter()
        {
            Finish();
        }
    }
}