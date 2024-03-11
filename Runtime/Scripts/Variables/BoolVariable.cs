using System;
using UnityEngine;

namespace com.simbask.sodata.Runtime
{
    [CreateAssetMenu(fileName = "BoolVar", menuName = "SO Data/Create new variable/Bool")]
    public class BoolVariable : ScriptableObject
    {
        [SerializeField] private bool _bool;

        public event Action<bool> OnValueChanged;

        public bool Value
        {
            get { return _bool; }
            set
            {
                if (_bool != value)
                {
                    _bool = value;
                    OnValueChanged?.Invoke(_bool);
                }
            }
        }
    }
}