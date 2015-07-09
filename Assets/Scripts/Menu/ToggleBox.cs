﻿using UnityEngine;
using System.Collections;
using Assets.Scripts.Menu;
using UnityEngine.UI;

namespace Assets.Scripts.Menu
{
    [RequireComponent(typeof (Toggle))]
    [RequireComponent(typeof (AllowedSelections))]
    public class ToggleBox : MonoBehaviour, ISelectable
    {
        private Toggle toggle;
        private MenuSelectable menuSelectable;
        private AllowedSelections allowedSelections;

        private void Awake()
        {
            toggle = GetComponent<Toggle>();
            menuSelectable = GetComponent<MenuSelectable>();
            allowedSelections = GetComponent<AllowedSelections>();
        }

        // Use this for initialization
        private void Start()
        {

        }

        // Update is called once per frame
        private void Update()
        {

        }

        public void Select(int playerNumber)
        {
//            toggle.targetGraphic.color = Color.blue;
        }

        public void Unselect(int playerNumber)
        {
//            toggle.targetGraphic.color = Color.white;
        }

        public bool AllowSelection(int playerNumber)
        {
            return allowedSelections.Allow(playerNumber);
        }


        public void Primary(MenuPlayerController player)
        {
//            toggle.isOn = !toggle.isOn;
        }

        public void Secondary(MenuPlayerController player)
        {
        }

        public void Left(MenuPlayerController player)
        {
        }

        public void Right(MenuPlayerController player)
        {
        }
    }
}