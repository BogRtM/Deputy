using RoR2;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deputy.Components
{
    public class DeputyAnimatorController : MonoBehaviour
    {
        private Animator modelAnimator;
        public static int combatLayerIndex;

        private AimAnimator aimAnimator;

        private CharacterBody characterBody;
        private InputBankTest inputBank;

        private const float combatDuration = 5f;

        private const float restYaw = 0f;
        private const float combatYaw = -1f;
        private const float combatRunYaw = -2f;
        private const float sprintCombatGroundYaw = 1f;
        private const float sprintCombatAirYaw = 2f;
        private float desiredYaw;

        private bool inCombat;
        private bool isMoving;
        private bool isSprinting;
        private bool isGrounded;

        private bool sprintYawSet;
        private float combatDampValue;
        private float combatDampVelocity;

        private combatState currentState;
        private float currentCombatWeight;
        private float combatTimer;

        public enum combatState
        {
            None,
            EnteringCombat,
            LeavingCombat
        }

        private void Awake()
        {
            modelAnimator = base.GetComponentInChildren<Animator>();
            combatLayerIndex = modelAnimator.GetLayerIndex("Body, Combat");
        }

        private void Start()
        {
            ModelLocator modelLocator = base.GetComponent<ModelLocator>();
            Transform modelTransform = modelLocator.modelTransform;
            aimAnimator = modelTransform.GetComponent<AimAnimator>();

            if (!aimAnimator)
            {
                Log.Error("Deputy aim animator is null!");
            }

            characterBody = base.GetComponent<CharacterBody>();
            inputBank = base.GetComponent<InputBankTest>();
        }

        private void Update()
        {
            currentCombatWeight = modelAnimator.GetLayerWeight(combatLayerIndex);

            switch (currentState)
            {
                case combatState.EnteringCombat:
                    combatDampValue = Mathf.SmoothDamp(currentCombatWeight, 1f, ref combatDampVelocity, 0.1f);
                    modelAnimator.SetLayerWeight(combatLayerIndex, combatDampValue);
                    break;

                case combatState.LeavingCombat:
                    combatDampValue = Mathf.SmoothDamp(currentCombatWeight, 0f, ref combatDampVelocity, 0.2f);
                    modelAnimator.SetLayerWeight(combatLayerIndex, combatDampValue);
                    break;

                default:
                    break;
            }
        }

        private void FixedUpdate()
        {
            if (inCombat)
            {
                combatTimer += Time.fixedDeltaTime;
                if(combatTimer >= combatDuration)
                {
                    combatTimer = 0f;
                    combatDampVelocity = 0f;
                    SetCombatState(DeputyAnimatorController.combatState.LeavingCombat);
                }
            }
        }

        public void UpdateAnimationParams()
        {
            isMoving = modelAnimator.GetBool("isMoving");
            isSprinting = modelAnimator.GetBool("isSprinting");
            isGrounded = modelAnimator.GetBool("isGrounded");

            SetYaw();
            SetPitch();
        }

        private void SetYaw()
        {
            if (isSprinting && inCombat && !sprintYawSet)
            {
                sprintYawSet = true;
                aimAnimator.giveupDuration = float.PositiveInfinity;
                aimAnimator.yawRangeMin = -175f;
                aimAnimator.yawRangeMax = 175f;
            }
            else if (!isSprinting && sprintYawSet)
            {
                sprintYawSet = false;
                aimAnimator.giveupDuration = 3f;
                aimAnimator.yawRangeMin = -80f;
                aimAnimator.yawRangeMax = 80f;
            }

            if (isSprinting && inCombat && !isGrounded)
            {
                desiredYaw = sprintCombatAirYaw;
            }
            else if (isSprinting && inCombat && isGrounded)
            {
                desiredYaw = sprintCombatGroundYaw;
            }
            else if (!isSprinting && isMoving && inCombat)
            {
                desiredYaw = combatRunYaw;
            }
            else if (!isMoving && !isSprinting && inCombat)
            {
                desiredYaw = combatYaw;
            }
            else if (!inCombat)
            {
                desiredYaw = restYaw;
            }



            //yawDampValue = Mathf.SmoothDamp(modelAnimator.GetFloat("yawControl"), desiredYaw, ref yawDampVelocity, 0.1f);
            modelAnimator.SetFloat("yawControl", desiredYaw);
        }

        private void SetPitch()
        {
            if ((!isGrounded || isMoving) && !isSprinting)
            {
                modelAnimator.SetFloat("pitchControl", 1f);
            }
            else
            {
                modelAnimator.SetFloat("pitchControl", 0f);
            }
        }

        public void SetCombatState(combatState state)
        {
            currentState = state;

            combatTimer = 0f;
            combatDampVelocity = 0f;

            if (state == combatState.EnteringCombat)
                inCombat = true;
            else if (state == combatState.LeavingCombat)
                inCombat = false;
        }
    }
}
