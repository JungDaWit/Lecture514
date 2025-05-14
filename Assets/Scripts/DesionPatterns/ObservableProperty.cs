using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DesignPatten
{
    public class ObservableProperty<T>
    {
        [SerializeField] private T _value;

        public T Value
        {
            get => _value;
            set
            {
                if (_value.Equals(value)) return;
                _value = value;
                Notify();
            }
        }
        private UnityEvent<T> onValueChanged = new();

        public ObservableProperty(T value = default)
        {

        }

        public void Subscrie(UnityAction<T> action)
        {
            onValueChanged.AddListener(action);
        }
        public void Unsubscride(UnityAction<T> action)
        {
            onValueChanged.RemoveListener(action);
        }
        public void UnsubscrideAll()
        {
            onValueChanged.RemoveAllListeners();
        }
        private void Notify()
        {
            onValueChanged?.Invoke(Value);
        }

    }
}
