using System;
using UnityEngine;

namespace com.simbask.sodata.Runtime
{
    [CreateAssetMenu(fileName = "IntVar", menuName = "SO Data/Create new variable/Int")]
    public class IntVariable : ScriptableObject
    {
        [SerializeField] private int _int;

        public event Action<int> OnValueChanged;

        public int Value
        {
            get { return _int; }
            set
            {
                if (_int != value)
                {
                    _int = value;
                    OnValueChanged?.Invoke(_int);
                }
            }
        }
    }
}