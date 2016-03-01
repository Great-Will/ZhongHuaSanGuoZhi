﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind801 : ConditionKind
    {
        public override bool CheckConditionKind(Person person)
        {
            return person.BelongedFaction != null;
        }
    }
}

