using UnityEngine;

namespace FK.uNody.Logic.Demo
{
    [NodeWidth(NodeSize.Small)]
    public class DemoLogicNode : LogicNode
    {
        public override void Execute()
        {
            Debug.Log("Im DemoLogicNode!");
        }
    }
}