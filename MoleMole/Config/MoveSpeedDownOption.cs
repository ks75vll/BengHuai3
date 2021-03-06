﻿namespace MoleMole.Config
{
    using MoleMole;
    using System;

    public class MoveSpeedDownOption : ConfigAbilityStateOption
    {
        public DynamicFloat MoveSpeedRatio;

        public override void ChangeModifierConfig(ConfigAbilityModifier modifier)
        {
            modifier.Properties.Add("Animator_MoveSpeedRatio", this.MoveSpeedRatio);
        }

        public override AbilityState GetMatchingAbilityState()
        {
            return AbilityState.MoveSpeedDown;
        }
    }
}

