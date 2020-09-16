using System;
using UnityEngine;
using CabinIcarus.IcSkillSystem.SkillSystem.Runtime.Utils;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/PhysicsModule/JointSpring Value")]
    public partial class JointSpringValueNode:ValueNode<ValueInfo<UnityEngine.JointSpring>>
    {
        [SerializeField]
        private UnityEngine.JointSpring _value;
   
        private ValueInfo<UnityEngine.JointSpring> _variableValue;
   
        protected override ValueInfo<UnityEngine.JointSpring> GetTValue()
        {
            _variableValue = _value;
            return _variableValue;
        }
    }
}