using LLScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace BoomboxMod
{
    class BoomboxMod : MonoBehaviour
    {

#pragma warning disable IDE0051 // Remove unused private members
        private const string modVersion = "1.0.0";
        private const string repositoryOwner = "Daioutzu";
        private const string repositoryName = "LLBMM-BoomboxMod";
#pragma warning restore IDE0051

        public static BoomboxMod Instance { get; private set; }

        public static void Initialize()
        {
            GameObject gameObject = new GameObject("BoomboxMod"); //The game object is what we use to interact with our mod
            Instance = gameObject.AddComponent<BoomboxMod>();
            DontDestroyOnLoad(gameObject); // Makes sure our game object isn't destroyed
            Debug.Log($"[LLBMM] {Instance.name}: Intitialized");
        }

        void Update()
        {
            if (UIScreen.currentScreens[0]?.screenType == ScreenType.GAME_HUD)
            {
                ScreenGameHud screenGameHud = UIScreen.currentScreens[0] as ScreenGameHud;
                if (screenGameHud.lbTrack.gameObject.activeSelf == true)
                {
                    screenGameHud.lbTrack.gameObject.SetActive(false);
                }
                if (screenGameHud.imtextTime.gameObject.activeSelf == true)
                {
                    screenGameHud.imtextTime.gameObject.SetActive(false);
                }
            }
        }
    }
}
