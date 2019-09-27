using System;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/Physics2DModule/ColliderDistance2D Value")]
    public partial class ColliderDistance2DValueNode:ValueNode
    {
        [SerializeField]
        private UnityEngine.ColliderDistance2D _value;

        public override Type ValueType { get; } = typeof(UnityEngine.ColliderDistance2D);
        
        protected override object GetOutValue()
        {
            return _value;
        }
    }
}