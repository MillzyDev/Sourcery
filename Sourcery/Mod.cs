using MelonLoader;
using UnityEngine;

#if !QUEST
using Microsoft.Win32;
#endif

namespace Sourcery
{
    public class Mod : MelonMod
    {
        public override void OnLateInitializeMelon()
        {
            if (PlayerPrefs.GetInt("SourceryMod.noTutorial", -1) == -1)
                PlayerPrefs.SetInt("SourceryMod.noTutorial", 0);
        }
    }
}
