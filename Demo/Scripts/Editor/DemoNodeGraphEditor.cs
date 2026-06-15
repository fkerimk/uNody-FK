using UnityEngine;
using System;
using FK.uNodyEditor;

namespace FK.uNody.Demo
{
    using uNodyEditor;

    // Associate this editor with the TestGraph class
    [CustomNodeGraphEditor(typeof(DemoNodeGraph))]
    public class DemoNodeGraphEditor : NodeGraphEditor
    {
        public override string GetNodeMenuName(Type type)
        {
            // Only show nodes if their namespace is "PuppyDragon.uNody.Demo"
            if (type.Namespace != "PuppyDragon.uNody.Demo")
            {
                // Returning null hides the node from the context menu
                return null;
            }
            else
            {
                // Otherwise, use the default menu name
                return base.GetNodeMenuName(type);
            }
        }
    }
}