using System;
using UnityEngine;
using CabinIcarus.IcSkillSystem.SkillSystem.Runtime.Utils;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/System/Int32 Value")]
    public partial class Int32ValueNode:ValueNode<ValueInfo<System.Int32>>
    {
        [SerializeField]
        private System.Int32 _value;
   
        private ValueInfo<System.Int32> _variableValue;
   
        protected override ValueInfo<System.Int32> GetTValue()
        {
            _variableValue = _value;
            return _variableValue;
        }
    }
}