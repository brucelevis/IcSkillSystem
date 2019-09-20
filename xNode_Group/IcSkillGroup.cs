//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年09月19日-21:25
//Assembly-CSharp

using CabinIcarus.IcSkillSystem.Runtime.xNode_NPBehave_Node;
using NPBehave;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.xNode_Group
{
    [CreateAssetMenu(fileName = "New IcSkill Group",menuName = "CabinIcarus/IcSkillSystem/Group")]
    public class IcSkillGroup:NodeGraph
    {
        /// <summary>
        /// 开始,返回Node
        /// </summary>
        /// <returns></returns>
        public Root Start()
        {
            RootNode rootNode = null;
            foreach (var node in nodes)
            {
                if (node.GetType() == typeof(RootNode))
                {
                    rootNode = (RootNode) node.GetValue(null);
                    break;
                }
            }

            if (!rootNode)
            {
                return null;
            }

            return (Root) rootNode.Node;
        }
    }
}