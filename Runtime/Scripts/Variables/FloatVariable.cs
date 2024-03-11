using System;
using UnityEngine;

namespace com.simbask.sodata.Runtime
{
    [CreateAssetMenu(fileName = "FloatVar", menuName = "SO Data/Create new variable/Float")]
    public class FloatVariable : ScriptableObject
    {
        [SerializeField] private float _float;

        public event Action<float> OnValueChanged;

        public float Value
        {
            get { return _float; }
            set
            {
                if (_float != value)
                {
                    _float = value;
                    OnValueChanged?.Invoke(value);
                }
            }
        }
    }
}