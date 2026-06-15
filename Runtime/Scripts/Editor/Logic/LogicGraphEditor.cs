using FK.uNody.Logic;
using UnityEngine;
using UnityEditor;

namespace FK.uNodyEditor.Logic
{
    using FK.uNody.Logic;

    [CustomNodeGraphEditor(typeof(LogicGraph))]
    public class LogicGraphEditor : NodeGraphEditor
    {
        public override void OnToolbarGUI()
        {
            if (GUILayout.Button("Run", EditorStyles.toolbarButton))
            {
                var logicGraph = target as LogicGraph;
                logicGraph.Execute();
                logicGraph.Blackboard?.ClearRuntimeVars();
            }
        }
    }
}