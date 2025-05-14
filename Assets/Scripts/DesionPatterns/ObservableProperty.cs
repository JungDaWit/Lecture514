using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


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
        }
    }
    private UnityEvent<T> onValueChanged = new();

  

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
    private void Nitify()
    {
        onValueChanged?.Invoke(Value);
    }
    
}
