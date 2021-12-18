using MelonLoader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using VRC.Core;
using VRC.UI;
using NickysMenu.utils;
using VRChatUtilityKit.Ui;

/*
 This class is for handling the Left wing menu Gui
 */
namespace NickysMenu.gui

{
    class LeftWingMenu
    {

        // chnages the main quickmenu title
        public IEnumerator OnMainTitleRun(string message)
        {
            // whenever the usermanage face is avctive 
            while (GameObject.Find("UserInterface").GetComponentInChildren<VRC.UI.Elements.QuickMenu>(true) == null) yield return null;

            Transform Main_Menu_title = GameObject.Find("UserInterface").transform.Find(Const.MainMenuTitlePath);
            Main_Menu_title.GetComponent<TMPro.TextMeshProUGUI>().text = message;
        }

        public IEnumerator onSafty()
        {
            // whenever the usermanage face is avctive 
            while (GameObject.Find("UserInterface").GetComponentInChildren<VRC.UI.Elements.QuickMenu>(true) == null) yield return null;

            Transform saftey = GameObject.Find("UserInterface").transform.Find(Const.toggleSaftyPath);

            saftey.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
            //saftey.GetComponent<Button>().onClick.AddListener(GuiActions.DumpAvatarInfo());
        }

        // sets the title of the left wing menu
        public IEnumerator OnLeftWingTitle(string message)
        {
            // whenever the usermanage face is avctive 
            while (GameObject.Find("UserInterface").GetComponentInChildren<VRC.UI.Elements.QuickMenu>(true) == null) yield return null;

            Transform Main_Menu_title = GameObject.Find("UserInterface").transform.Find(Const.Leftwingtitlepath);
            Main_Menu_title.GetComponent<TMPro.TextMeshProUGUI>().text = Const.ModTitle;
        }


        // sets the mod menu button's text 
        public IEnumerator OnModMenuButton()
        {
            // whenever the usermanage face is avctive 
            while (GameObject.Find("UserInterface").GetComponentInChildren<VRC.UI.Elements.QuickMenu>(true) == null) yield return null;

            Transform Main_Menu_title = GameObject.Find("UserInterface").transform.Find(Const.LeftwingFirstButtonTitle);
            Main_Menu_title.GetComponent<TMPro.TextMeshProUGUI>().text = Const.ModMenuButton;
        }



        //TODO: get a window to dislay mod infox
        public IEnumerator OnModMenuButtonPress()
        {
            // whenever the usermanage face is avctive 
            while (GameObject.Find("UserInterface").GetComponentInChildren<VRC.UI.Elements.QuickMenu>(true) == null) yield return null;
            Transform modinfoButton = GameObject.Find("UserInterface").transform.Find(Const.GUIModButton);

            modinfoButton.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
            modinfoButton.GetComponent<Button>().onClick.AddListener(GuiActions.openModInfoMenu());
        }




    }
}


  




