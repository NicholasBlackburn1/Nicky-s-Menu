using MelonLoader;
using NickysMenu.utils;
using NickysMenu.registers;
using System;

namespace NickysMenu
{
    public static class BuildInfo
    {
        public const string Name = "Nicky's Mod Menu"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "A mod That will Allow you to Mod vrc to your harts desire"; // Description for the Mod.  (Set as null if none)
        public const string Author = "Nicky Blackburn"; // Author of the Mod.  (MUST BE SET)
        public const string Company = "Blackburn Software"; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class NickysMenu : MelonMod
    {

        public static MelonPreferences_Category settingsCategory;
        private RegisterGuis registerUI = new RegisterGuis();

        public override void OnApplicationStart() // Runs after Game Initialization.
        {
            logger.warning("Starting up " +$"{BuildInfo.Name}"+".....");


            logger.ok("Successfully started" + $"{BuildInfo.Name}" + ".....");
        }

        public override void OnApplicationLateStart() // Runs after OnApplicationStart.
        {
          
        }

        public override void OnSceneWasLoaded(int buildindex, string sceneName) // Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
        {
            
        }

        public override void OnSceneWasInitialized(int buildindex, string sceneName) // Runs when a Scene has Initialized and is passed the Scene's Build Index and Name.
        {
            // trys to register gui layout to vrc
            try
            {
                registerUI.RegisterGuiLayout();
            }
            catch (Exception e)
            {
                logger.error(e.ToString());
            }
        }

        public override void OnUpdate() // Runs once per frame.
        {

            // trys to register vrc button actions 
            try
            {
                registerUI.RegisterGuiActions();
            } 
            catch(Exception e)
            {
                logger.error(e.ToString());
            }
        }

        public override void OnFixedUpdate() // Can run multiple times per frame. Mostly used for Physics.
        {
           
        }

        public override void OnLateUpdate() // Runs once per frame after OnUpdate and OnFixedUpdate have finished.
        {
            
        }

        public override void OnGUI() // Can run multiple times per frame. Mostly used for Unity's IMGUI.
        {
            
        }

        public override void OnApplicationQuit() // Runs when the Game is told to Close.
        {
            
        }

        public override void OnPreferencesSaved() // Runs when Melon Preferences get saved.
        {
          
        }

        public override void OnPreferencesLoaded() // Runs when Melon Preferences get loaded.
        {
           
        }

        public override void BONEWORKS_OnLoadingScreen() // Runs when BONEWORKS shows the Loading Screen. Only runs if the Melon is used in BONEWORKS.
        {
           
        }
    }
}