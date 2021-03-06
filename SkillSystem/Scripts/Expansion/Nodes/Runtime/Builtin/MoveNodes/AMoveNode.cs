﻿using CabinIcarus.IcSkillSystem.Nodes.Runtime;
using CabinIcarus.IcSkillSystem.Nodes.Runtime.Attributes;
using NPBehave;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Expansion.Runtime.Builtin.Nodes
{
    public abstract class AMoveNode:ANPBehaveNode<Action>
    {
        [Input(ShowBackingValue.Always,ConnectionType.Override,TypeConstraint.Inherited)]
        private GameObject _target;

        [SerializeField,Input(ShowBackingValue.Always,ConnectionType.Override,TypeConstraint.Inherited)] 
        private Action.Result _moveResult = Action.Result.PROGRESS;
        
        [SerializeField,Input(ShowBackingValue.Always,ConnectionType.Override,TypeConstraint.Inherited)] 
        private Action.Result _completeResult = Action.Result.SUCCESS;

        protected Action.Result MoveResult => GetInputValue(nameof(_moveResult),_moveResult);

        protected Action.Result CompleteResult => GetInputValue(nameof(_completeResult),_completeResult);

        protected Transform Tran => GetInputValue(nameof(_target),SkillGroup.Owner)?.transform;

        protected sealed override Action GetOutValue()
        {
            return new Action(Move);
        }

        protected abstract Action.Result Move(Action.Request arg);
    }
}