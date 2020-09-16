using System;
using UnityEngine;
using CabinIcarus.IcSkillSystem.SkillSystem.Runtime.Utils;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/Physics2DModule/CapsuleDirection2D Value")]
    public partial class CapsuleDirection2DValueNode:ValueNode<ValueInfo<UnityEngine.CapsuleDirection2D>>
    {
        [SerializeField]
        private UnityEngine.CapsuleDirection2D _value;
   
        private ValueInfo<UnityEngine.CapsuleDirection2D> _variableValue;
   
        protected override ValueInfo<UnityEngine.CapsuleDirection2D> GetTValue()
        {
            _variableValue = _value;
            return _variableValue;
        }
    }
}