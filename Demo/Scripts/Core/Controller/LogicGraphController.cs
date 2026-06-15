using UnityEngine;

namespace FK.uNody.Logic.Demo
{
    public class LogicGraphController : MonoBehaviour
    {
        [SerializeField]
        private LogicGraph logicGraph;

        void Start()
        {
            logicGraph.Execute();
        }
    }
}