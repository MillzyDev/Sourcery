using MelonLoader;

#if !QUEST
using Microsoft.Win32;
#endif

namespace Sourcery
{
    public class Mod : MelonMod
    {
#if !QUEST
        private const string _modRegistryPath = @"HKEY_CURRENT_USER\BONELAB Mods\Sourcery";
        private const string _noTutorialKey = "noTutorial";
#endif

        public override void OnInitializeMelon()
        {
#if !QUEST
            if (Registry.GetValue(_modRegistryPath, _noTutorialKey, null) == null)
                Registry.SetValue(_modRegistryPath, _noTutorialKey, 0, RegistryValueKind.DWord);
#else
            // TODO: Quest tutorial check
#endif
        }
    }
}
