﻿using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using UnityStandardAssets.CrossPlatformInput;

namespace Assets.Scripts.Player.States
{
    public class PunchState : PlayerState
    {
        [SerializeField] private int waitFrames = 10;
        [SerializeField] private bool directionalControl = true;
        private bool flip = false;
        private int waitCounter;
        private Vector2 move;

        public virtual new void OnStateEnter(Animator animator, AnimatorStateInfo stateinfo, int layerindex)
        {
            base.OnStateEnter(animator, stateinfo, layerindex);
            waitCounter = waitFrames;
        }

        public virtual new void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            base.OnStateUpdate(animator, stateInfo, layerIndex);
            waitCounter -= 1;
            if (waitCounter > 0)
            {
                if (flip && directionalControl)
                {
                    flip = false;
                    playerController.Flip();
                }
            }
        }

        public virtual new void OnStateExit(Animator animator, AnimatorStateInfo stateinfo, int layerindex)
        {
        }

        public override string GetName()
        {
            return "Punch";
        }

        public override void Move(float x, float y)
        {
            base.Move(x, y);
            move = new Vector2(x, y);
            if ((move.x < 0 && playerController.facingRight) || (move.x > 0 && !playerController.facingRight))
            {
                flip = true;
            }
        }

        public override void Left()
        {
        }

        public override void Right()
        {
        }
    }
}