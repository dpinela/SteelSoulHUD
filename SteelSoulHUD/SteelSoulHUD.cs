using Modding;

namespace SteelSoulHUD
{
    public class SteelSoulHUD : Mod, ITogglableMod
    {
        public override void Initialize()
        {
            On.PlayMakerFSM.OnEnable += UseSteelHUD;
        }

        public void Unload()
        {
            On.PlayMakerFSM.OnEnable -= UseSteelHUD;
        }

        public override string GetVersion() => "1.0";

        private static void UseSteelHUD(On.PlayMakerFSM.orig_OnEnable orig, PlayMakerFSM fsm)
        {
            orig(fsm);
            if (fsm.FsmName == "Load Animation" && fsm.gameObject.name == "HUD_frame")
            {
                var setAnims = fsm.GetState("Set Anims");
                setAnims.Actions[6] = new NopAction();
            }
        }
    }
}
