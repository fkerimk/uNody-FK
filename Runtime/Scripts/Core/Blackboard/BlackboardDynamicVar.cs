using UnityEngine;

namespace FK.uNody
{
    public abstract class BlackboardDynamicVar<T> : BlackboardVar
    {
        [SerializeField]
        private T value;

        public override object Value { get => value; set => this.value = (T)value; }

        public void SetValue(T value) => this.value = value;
        public T GetValue() => value;
    }
}
